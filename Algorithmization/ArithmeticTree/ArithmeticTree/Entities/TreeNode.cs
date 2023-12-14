using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTree.Entities
{
    internal class TreeNode
    {
        public TreeNodeType Type { get; set; }

        public string? OpCode { get; set; }

        public double Number { get; set; }

        public TreeNode? Left { get; set; }

        public TreeNode? Right { get; set; }

        public TreeNode? Parent { get; set; }

        public void ProcessLeftToRight(StringBuilder sb)
        {
            if (Type == TreeNodeType.Number)
            {
                sb.Append(Number);
                return;
            }

            sb.Append("(");
            Left?.ProcessLeftToRight(sb);
            sb.Append($" {OpCode} ");
            Right?.ProcessLeftToRight(sb);
            sb.Append(")");
        }

        public void ProcessTopDown(StringBuilder sb)
        {
            if (Type == TreeNodeType.Number)
            {
                sb.Append(Number);
                return;
            }

            sb.Append($"({OpCode} ");
            Left?.ProcessTopDown(sb);
            sb.Append(" ");
            Right?.ProcessTopDown(sb);
            sb.Append(")");
        }

        public void ProcessBottomUp(StringBuilder sb)
        {
            if (Type == TreeNodeType.Number)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" ");
                }

                sb.Append(Number);
                return;
            }

            Left?.ProcessBottomUp(sb);
            Right?.ProcessBottomUp(sb);
            if (sb.Length > 0)
            {
                sb.Append(" ");
            }

            sb.Append(OpCode);
        }

        public double Calculate()
        {
            if (Type == TreeNodeType.Number)
            {
                return Number;
            }

            var left = Left?.Calculate() ?? 0;
            var right = Right?.Calculate() ?? 0;
            switch (OpCode)
            {
                case "+":
                    return left + right;
                case "-":
                    return left - right;
                case "*":
                    return left * right;
                case "/":
                    return left / right;
            }

            return 0;
        }
    }
}
