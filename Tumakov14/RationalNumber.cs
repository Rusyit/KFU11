namespace Tumakov14
{
    [DeveloperInfo1Attribut("Рустам", "05.12.2023")]

    class RationalNum
    {
        readonly int chislitel;
        readonly int denominator;

        public static RationalNum MakeRationalNumber(int chislitel, int denominator)
        {
            if (denominator > 0)
            {
                return new RationalNum (chislitel, denominator);
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return $"{chislitel}";
            }
            else
            {
                return $"{chislitel}/{denominator}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is RationalNum rationalNum)
            {
                int newDenominator = FindingDenominator(denominator, rationalNum.denominator);
                int newChislitel1 = chislitel * (newDenominator / denominator);
                int newChislitel2 = rationalNum.chislitel * (newDenominator / rationalNum.denominator);

                if (newChislitel1 == newChislitel2)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private static int FindingDenominator(int Denominator1, int Denominator2)
        {
            int Num1 = Denominator1;
            int Num2 = Denominator2;

            while ((Num1 != 0) && (Num2 != 0))
            {
                if (Num1 > Num2)
                {
                    Num1 %= Num2;
                }
                else
                {
                    Num2 %= Num1;
                }
            }

            return (Num1 * Num2) / (Num1 + Num2);
        }

        public static RationalNum operator +(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel = (rationalNum1.chislitel * (newDenominator / rationalNum1.denominator)) + (rationalNum2.chislitel * (newDenominator / rationalNum1.denominator));

            return new RationalNum(newChislitel, newDenominator);
        }

        public static RationalNum operator -(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel = (rationalNum1.chislitel * (newDenominator / rationalNum1.denominator)) - (rationalNum2.chislitel * (newDenominator / rationalNum2.denominator));

            return new RationalNum(newChislitel, newDenominator);
        }

        public static RationalNum operator *(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            return new RationalNum(rationalNum1.chislitel * rationalNum2.chislitel, rationalNum1.denominator * rationalNum2.denominator);
        }

        public static RationalNum operator /(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            return new RationalNum(rationalNum1.chislitel * rationalNum2.denominator, rationalNum1.denominator * rationalNum2.chislitel);
        }


        public static int operator %(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            RationalNum rationalNum = rationalNum1 / rationalNum2;

            return (rationalNum.chislitel % rationalNum.denominator);
        }

        public static bool operator ==(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 == newChislitel2;
        }

        public static bool operator !=(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 != newChislitel2;
        }

        public static bool operator >(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 > newChislitel2;
        }

        public static bool operator <(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 < newChislitel2;
        }


        public static bool operator >=(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 >= newChislitel2;
        }

        public static bool operator <=(RationalNum rationalNum1, RationalNum rationalNum2)
        {
            int newDenominator = FindingDenominator(rationalNum1.denominator, rationalNum2.denominator);
            int newChislitel1 = rationalNum1.chislitel * (newDenominator / rationalNum1.denominator);
            int newChislitel2 = rationalNum2.chislitel * (newDenominator / rationalNum2.denominator);

            return newChislitel1 <= newChislitel2;
        }

        public static RationalNum operator ++(RationalNum rationalNum)
        {
            return new RationalNum(rationalNum.chislitel + rationalNum.denominator, rationalNum.denominator);
        }

        public static RationalNum operator --(RationalNum rationalNum)
        {
            return new RationalNum(rationalNum.chislitel - rationalNum.denominator, rationalNum.denominator);
        }

        public static explicit operator float(RationalNum rationalNum)
        {
            return (float)rationalNum.chislitel / rationalNum.denominator;
        }

        public static explicit operator int(RationalNum rationalNum)
        {
            return rationalNum.chislitel / rationalNum.denominator;
        }

        private RationalNum(int chislitel, int denominator)
        {
            this.chislitel = chislitel;
            this.denominator = denominator;
        }
    }
}
