using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectorAutomat.Services
{
    public class StringDetector
    {
        private State _state;

        public bool Detect(string input)
        {
            _state = State.Start;
            foreach (var ch in input)
            {
                if (char.IsWhiteSpace(ch))
                {
                    continue;
                }

                var charClass = Classify(ch);
                ReadChar(charClass);
            }

            ReadChar(CharClass.EndMarker);

            return _state == State.Success;
        }

        private void ReadChar(CharClass charClass)
        {
            switch (_state)
            {
                case State.None:
                    _state = State.Error;
                    break;
                case State.Start:
                    switch (charClass)
                    {
                        case CharClass.Alpha:
                            _state = State.Letter;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Fail;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.Letter:
                    switch (charClass)
                    {
                        case CharClass.LeftBracket:
                            _state = State.LeftBracket;
                            break;
                        case CharClass.Comma:
                            _state = State.VariableSeparator;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.VariableSeparator:
                    switch (charClass)
                    {
                        case CharClass.Alpha:
                            _state = State.Letter;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Fail;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.LeftBracket:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.Dimension;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Fail;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.Dimension:
                    switch (charClass)
                    {
                        case CharClass.RightBracket:
                            _state = State.RightBracket;
                            break;
                        case CharClass.Comma:
                            _state = State.DimensionSeparator;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Fail;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.RightBracket:
                    switch (charClass)
                    {
                        case CharClass.Comma:
                            _state = State.VariableSeparator;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.DimensionSeparator:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.Dimension;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Fail;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                default:
                    _state = State.Error;
                    break;
            }
        }

        private CharClass Classify(char ch)
        {
            if (ch == ',')
            {
                return CharClass.Comma;
            }

            if (ch == '(')
            {
                return CharClass.LeftBracket;
            }

            if (ch == ')')
            {
                return CharClass.RightBracket;
            }

            if (char.IsLetter(ch))
            {
                return CharClass.Alpha;
            }

            if (char.IsDigit(ch))
            {
                return CharClass.Digit;
            }

            return CharClass.Other;
        }
    }
}
