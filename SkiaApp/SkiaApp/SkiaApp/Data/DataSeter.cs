using SkiaApp.model;
using System;
using System.Collections.Generic;

namespace SkiaApp.Data
{
    public class DataSeter
    {
        public Symbol GetSym(char v)
        {
            Symbol Sym = new Symbol();
            List<IFragments> items = new List<IFragments>();

            switch (v)
            {
                case 'А':
                    {
                        items.Add(line(5, 100, 30, 20));
                        items.Add(line(30, 20, 55, 100));
                        items.Add(line(18, 60, 42, 60));

                        break;
                    }

                case 'Б':
                    {
                        items.Add(line(5, 20, 50, 20));
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 50, 100, 75, 5, 100));

                        break;
                    }

                case 'В':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 20, 100, 40, 5, 60));
                        items.Add(line(5, 60, 100, 80, 5, 100));

                        break;
                    }

                case 'Г':
                    {
                        items.Add(line(5, 20, 55, 20));
                        items.Add(line(5, 100, 5, 20));

                        break;
                    }
                case 'Д':
                    {
                        items.Add(line(5, 100, 5, 80));
                        items.Add(line(5, 80, 55, 80));
                        items.Add(line(55, 100, 55, 80));
                        items.Add(line(25, 20, 35, 20));
                        items.Add(line(15, 80, 25, 20));
                        items.Add(line(35, 20, 45, 80));

                        break;
                    }

                case 'Е':
                    {
                        items.Add(line(5, 20, 55, 20));
                        items.Add(line(5, 60, 45, 60));
                        items.Add(line(5, 100, 55, 100));
                        items.Add(line(5, 20, 5, 100));

                        break;
                    }

                case 'Ж':
                    {
                        items.Add(line(5, 20, 55, 100));
                        items.Add(line(5, 100, 55, 20));
                        items.Add(line(30, 100, 30, 20));

                        break;
                    }

                case 'З':
                    {
                        items.Add(line(15, 20, 80, -20, 45, 60));
                        items.Add(line(35, 60, 45, 60));
                        items.Add(line(15, 100, 80, 140, 45, 60));

                        break;
                    }

                case 'И':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 100, 55, 30));
                        items.Add(line(55, 20, 55, 100));

                        break;
                    }

                case 'Й':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 100, 55, 30));
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(15, 20, 30, 50, 45, 20));

                        break;
                    }

                case 'К':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 60, 50, 20));
                        items.Add(line(5, 60, 50, 100));

                        break;
                    }

                case 'Л':
                    {
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(55, 20, 45, 20));
                        items.Add(line(45, 20, 35, 100, 5, 100));

                        break;
                    }

                case 'М':
                    {
                        items.Add(line(5, 100, 20, 20));
                        items.Add(line(20, 20, 30, 50));
                        items.Add(line(30, 50, 40, 20));
                        items.Add(line(40, 20, 55, 100));

                        break;
                    }

                case 'Н':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(5, 60, 55, 60));

                        break;
                    }

                case 'О':
                    {
                        items.Add(line(30, 60, 20, 38, null));

                        Sym.SetItems(items);
                        return Sym;
                    }

                case 'П':
                    {
                        items.Add(line(5, 100, 5, 20));
                        items.Add(line(55, 100, 55, 20));
                        items.Add(line(5, 20, 55, 20));

                        break;
                    }

                case 'Р':
                    {
                        items.Add(line(5, 100, 5, 20));
                        items.Add(line(5, 20, 100 , 40 ,5, 60));

                        break;
                    }

                case 'С':
                    {
                        items.Add(line(45, 20, -30, 60, 45, 100));

                        break;
                    }

                case 'Т':
                    {
                        items.Add(line(5, 20, 55, 20));
                        items.Add(line(30, 20, 30, 100));

                        break;
                    }

                case 'У':
                    {
                        items.Add(line(15, 20, 42, 60));
                        items.Add(line(45, 20, 40, 120, 5, 100));

                        break;
                    }

                case 'Ф':
                    {
                        items.Add(line(30, 20, 30, 100));
                        items.Add(line(20, 40, 10, 20, null));
                        items.Add(line(40, 40, 10, 20, null));

                        break;
                    }

                case 'Х':
                    {
                        items.Add(line(10, 20, 50, 100));
                        items.Add(line(10, 100, 50, 20));

                        break;
                    }

                case 'Ц':
                    {
                        items.Add(line(5, 20, 5, 85));
                        items.Add(line(45, 20, 45, 85));
                        items.Add(line(5, 85, 45, 85));
                        items.Add(line(45, 85, 55, 85));
                        items.Add(line(55, 85, 55, 100));

                        break;
                    }

                case 'Ч':
                    {
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(10, 20, 10, 50));
                        items.Add(line(10, 50, 20, 60));
                        items.Add(line(20, 60, 55, 60));

                        break;
                    }

                case 'Ш':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(30, 20, 30, 100));
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(5, 100, 55, 100));

                        break;
                    }

                case 'Ы':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(5, 60, 90, 80, 5, 100));

                        break;
                    }
                case 'Щ':
                    {
                        items.Add(line(5, 20, 5, 85));
                        items.Add(line(25, 20, 25, 85));
                        items.Add(line(45, 20, 45, 85));
                        items.Add(line(5, 85, 45, 85));
                        items.Add(line(45, 85, 55, 85));
                        items.Add(line(55, 85, 55, 100));

                        break;
                    }
                case 'Э':
                    {
                        items.Add(line(15, 20, 55, 20, 55, 60));
                        items.Add(line(55, 60, 25, 60));
                        items.Add(line(15, 100, 55, 100, 55, 60));

                        break;
                    }

                case 'Ю':
                    {
                        items.Add(line(5, 20, 5, 100));
                        items.Add(line(5, 60, 18, 60));
                        items.Add(line(30, 60, 12, 40, null));

                        break;
                    }

                case 'Я':
                    {
                        items.Add(line(55, 20, 55, 100));
                        items.Add(line(55, 20, -30, 30, 55, 60));
                        items.Add(line(45, 60, 5, 100));

                        break;
                    }

                case ' ':
                    {
                        break;
                    }

                case ',':
                    {
                        items.Add(line(35, 85, 35, 100, 25, 100));
                        break;
                    }

                case '.':
                    {
                        items.Add(line(30, 97, 30, 99));
                        items.Add(line(28, 98.5f, 32, 98.5f));
                        break;
                    }

                case '?':
                    {
                        items.Add(line(20, 20, 100, 20, 35, 60));
                        items.Add(line(35, 60, 30, 60, 25, 70));
                        items.Add(line(25, 70, 25, 80));

                        items.Add(line(30, 97, 30, 99));
                        items.Add(line(28, 98.5f, 32, 98.5f));

                        break;
                    }

                case '!':
                    {
                        items.Add(line(30, 20, 30, 70));

                        items.Add(line(30, 97, 30, 99));
                        items.Add(line(28, 98.5f, 32, 98.5f));

                        break;
                    }

                default:
                    {
                        return null;
                    }
            }

            Sym.SetItems(items);
            return Sym;
        }

        /// <summary>
        /// Функция записи прямой линии
        /// </summary>
        private IFragments line(float x1, float y1, float x2, float y2)
        {
            Fragment fragment = new Fragment();
            fragment.SetFragment(new Line(x1, y1, x2, y2));

            return fragment;
        }
        /// <summary>
        /// Функция записи кривой Безье
        /// </summary>
        private IFragments line(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Fragment fragment = new Fragment();
            fragment.SetFragment(new Bezier(x1, y1, x2, y2, x3, y3));

            return fragment;
        }

        /// <summary>
        /// Функция записи овала
        /// </summary>
        private IFragments line(float x1, float y1, float rx, float ry, object o)
        {
            Fragment fragment = new Fragment();
            fragment.SetFragment(new Oval(x1, y1, rx, ry));

            return fragment;
        }
    }
}
