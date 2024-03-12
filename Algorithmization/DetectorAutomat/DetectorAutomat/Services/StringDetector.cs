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
            _state = State.Initial;
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
                case State.Initial:
                    switch (charClass)
                    {
                        case CharClass.Alpha:
                            _state = State.Name;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.Name:
                    switch (charClass)
                    {
                        case CharClass.Alpha:
                        case CharClass.Digit:
                            break;
                        case CharClass.LeftBracket:
                            _state = State.DimensionInitial;
                            break;
                        case CharClass.Comma:
                            _state = State.Initial;
                            break;
                        case CharClass.EndMarker:
                            _state = State.Success;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.DimensionInitial:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            _state = State.Dimension;
                            break;
                        default:
                            _state = State.Error;
                            break;
                    }
                    break;
                case State.Dimension:
                    switch (charClass)
                    {
                        case CharClass.Digit:
                            break;
                        case CharClass.RightBracket:
                            _state = State.RightBracket;
                            break;
                        case CharClass.Comma:
                            _state = State.DimensionInitial;
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
                            _state = State.Initial;
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
                    ('(', _, _) => CharClass.LeftBracket,
                    (')', _, _) => CharClass.RightBracket,
                    (_, true, _) => CharClass.Alpha,
                    (_, false, true) => CharClass.Digit,
                    _ => CharClass.Other,
                };
        }
    }
}
