﻿using System;
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
                        case CharClass.Digit:
                            _state = State.WholePart;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.WholePart:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.WholePart;
                            break;
                        case CharClass.Comma:
                            _state = State.Comma;
                            break;
                        case CharClass.LetterE:
                            _state = State.LetterE;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.Comma:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.FractionalPart;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.FractionalPart:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.FractionalPart;
                            break;
                        case CharClass.LetterE:
                            _state = State.LetterE;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.LetterE:
                    switch (charClass)
                    {
                        case CharClass.Operator:
                            _state = State.OrderOperator;
                            break;
                        case CharClass.Digit:
                            _state = State.OrderPart;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.OrderOperator:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.OrderPart;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.OrderPart:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.OrderPart;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
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

            return 
                (ch, char.IsLetter(ch), char.IsDigit(ch)) switch
                {
                    (',', _, _) => CharClass.Comma,
                    ('.', _, _) => CharClass.Comma,
                    ('-', _, _) => CharClass.Operator,
                    ('+', _, _) => CharClass.Operator,
                    ('e', _, _) => CharClass.LetterE,
                    ('E', _, _) => CharClass.LetterE,
                    (_, false, true) => CharClass.Digit,
                    _ => CharClass.Other,
                };

        }
    }
}
