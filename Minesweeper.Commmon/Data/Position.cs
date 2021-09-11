using System;

namespace Minesweeper.Common.Data
{
    public struct Position : IEquatable<Position>
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public bool IsPositive ()
        {
            return this.X >= 0 && this.Y >= 0;
        }

        public bool Equals(Position other)
        {
            return this.X == other.X && this.Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is Position other && this.Equals(other);
        }

        public override int GetHashCode()
        {
            return (this.X, this.Y).GetHashCode();
        }

        public int Distance(Position other)
        {
            var x = Math.Abs(this.X - other.X);
            var y = Math.Abs(this.Y - other.Y);
            return x < y ? y : x;
        }

        public static bool operator ==(Position lhs, Position rhs) => lhs.Equals(rhs);

        public static bool operator !=(Position lhs, Position rhs) => !(lhs == rhs);
    }
}