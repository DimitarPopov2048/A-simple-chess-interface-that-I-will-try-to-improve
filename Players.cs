using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
namespace Chess
{
	/// <summary>
	/// Description of Players.
	/// </summary>
	public class White
    {
        public List <Piece> A = new List<Piece>();
        public White()
        {
        }
        public White(string s)
        {
            var a = s.Split();
            for(int i = 0; i<a.Length; i++)
            {
                if(a[i][0] == 'P')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new PawnW(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'N')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Knight(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'B')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Bishop(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'R')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Rook(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'Q')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Queen(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'K')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new King(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
            }
        }
    }
    public class Black
    {
        public List <Piece> A = new List<Piece>();
        public Black()
        {
        }
        public Black(string s)
        {
            var a = s.Split();
            for(int i = 0; i<a.Length; i++)
            {
                if(a[i][0] == 'P')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new PawnB(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'N')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Knight(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'B')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Bishop(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'R')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Rook(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'Q')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new Queen(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
                else if(a[i][0] == 'K')
                {
                    for(int j = 1; j<a[i].Length; j++)
                    {
                        this.A.Add(new King(Convert.ToInt32((a[i][j]))-48,Convert.ToInt32(a[i][j+1])-48));
                        j++;
                    }
                }
            }
        }
    }
    public class Piece
    {
        public int x,y;
        public Image img;
        public Piece()
        {
        }
        public Piece(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }

}
