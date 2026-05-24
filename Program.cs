using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Chess
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}
		public int move = 1;
        public int br1 = 0;
        public List<int[]> PM =new List<int[]>();
        public int px,py;
        public static StreamReader h = new StreamReader(@"C:\Users\dimit\OneDrive\Documents\SharpDevelop Projects\Chess\Chess\TextTemplate2.tt");
        White W = new White();
        Black B = new Black();
        public static void Colors(List<int[]> PM, Buttons K)
        {
            for(int i = 0; i<K.A.Count; i++)
            {
                for(int j = 0; j<PM.Count; j++)
                {
                    if(i+1 == PM[j][0] + (PM[j][1]-1)*8)
                    {
                        K.A[i].BackColor = Color.Firebrick;
                    }
                }
            }
        }
        public class Buttons
        {
            public List <Button> A = new List<Button>();
            public Buttons()
            {
            }
        }
        public Buttons K = new Buttons();
        public void Addk (Buttons K)
        {
            K.A.Add(button1); K.A.Add(button2); K.A.Add(button3); K.A.Add(button4); K.A.Add(button5); K.A.Add(button6); K.A.Add(button7); K.A.Add(button8);
            K.A.Add(button9); K.A.Add(button10); K.A.Add(button11); K.A.Add(button12); K.A.Add(button13); K.A.Add(button14); K.A.Add(button15); K.A.Add(button16);
            K.A.Add(button17); K.A.Add(button18); K.A.Add(button19); K.A.Add(button20); K.A.Add(button21); K.A.Add(button22); K.A.Add(button23); K.A.Add(button24);
            K.A.Add(button25); K.A.Add(button26); K.A.Add(button27); K.A.Add(button28); K.A.Add(button29); K.A.Add(button30); K.A.Add(button31); K.A.Add(button32);
            K.A.Add(button33); K.A.Add(button34); K.A.Add(button35); K.A.Add(button36); K.A.Add(button37); K.A.Add(button38); K.A.Add(button39); K.A.Add(button40);
            K.A.Add(button41); K.A.Add(button42); K.A.Add(button43); K.A.Add(button44); K.A.Add(button45); K.A.Add(button46); K.A.Add(button47); K.A.Add(button48);
            K.A.Add(button49); K.A.Add(button50); K.A.Add(button51); K.A.Add(button52); K.A.Add(button53); K.A.Add(button54); K.A.Add(button55); K.A.Add(button56);
            K.A.Add(button57); K.A.Add(button58); K.A.Add(button59); K.A.Add(button60); K.A.Add(button61); K.A.Add(button62); K.A.Add(button63); K.A.Add(button64);
        }
        void Button65Click(object sender, EventArgs e)
        {
            if(K.A.Count<64)
            {
                Addk(K);
                W = new White(h.ReadLine());
                B = new Black(h.ReadLine());
                //label1.Text = W.A.Count + " " + B.A.Count;
            }
            int br = 0;
            for(int i = 0; i<K.A.Count; i++)
            {
                K.A[i].Size = new Size(this.Height/67*8,this.Height/67*8);
                K.A[i].Location = new Point((i%8)*(this.Height/67)*8 + this.Width/4,this.Height-K.A[i].Height*(i/8 + 1) - 55);
                K.A[i].Text = "";
                if(br%2 == 0)
                {
                    K.A[i].BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    K.A[i].BackColor = Color.GhostWhite;
                }
                br++;
                if(i%8 == 7)
                {
                    br++;
                }
                for(int j = 0; j<W.A.Count; j++)
                {
                    if(W.A[j].x + (W.A[j].y-1)*8 == i + 1)
                    {
                        if(W.A[j] is PawnW)
                        {
                            W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\PawnW.png");
                            K.A[i].BackgroundImage = W.A[j].img;
                        }
                        else if(W.A[j] is Knight)
                        {
                            W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\KnightW.png");
                            K.A[i].BackgroundImage = W.A[j].img;
                        }
                        else if(W.A[j] is Bishop)
                        {
                            W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\BishopW.png");
                            K.A[i].BackgroundImage = W.A[j].img;
                        }
                        else if(W.A[j] is Rook)
                        {
                        	W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\RookW.png");
                        	K.A[i].BackgroundImage = W.A[j].img;
                        }
                        else if(W.A[j] is Queen)
                        {
                            W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\QueenW.png");
                            K.A[i].BackgroundImage = W.A[j].img;
                        }
                        else if(W.A[j] is King)
                        {
                           W.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\KingW.png");
                           K.A[i].BackgroundImage = W.A[j].img;
                        }
                    }
                }
                for(int j = 0; j<B.A.Count; j++)
                {
                    if(B.A[j].x + (B.A[j].y-1)*8 == i + 1)
                    {
                        if(B.A[j] is PawnB)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\PawnB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                            //label1.Text += i + " ";
                        }
                        else if(B.A[j] is Knight)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\KnightB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                            button64.BackgroundImage = Image.FromFile(@"C:\Users\dimit\Downloads\KnightB.png");
                        }
                        else if(B.A[j] is Bishop)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\BishopB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                        }
                        else if(B.A[j] is Rook)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\RookB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                        }
                        else if(B.A[j] is Queen)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\QueenB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                        }
                        else if(B.A[j] is King)
                        {
                            B.A[j].img = Image.FromFile(@"C:\Users\dimit\Downloads\KingB.png");
                            K.A[i].BackgroundImage = B.A[j].img;
                        }
                    }
                }
            }
            button65.Size = K.A[0].Size;
            button65.Location = new Point(8*K.A[0].Width + this.Width/3,0);
            label1.Size = new Size(this.Height/67*32,this.Height/67*32);
            label1.Location = new Point(8*K.A[0].Width + this.Width/3,label1.Height);
        }
        
        public void POS(ref int x4, ref int y4, ref int move, ref int br, ref White W, ref Black B, ref List<int[]> PM, ref int px1, ref int py1, Buttons K)
        {
            int x = x4; int y = y4;
            for(int i = 0; i<K.A.Count; i++)
            {
                if((i/8 + i%8)%2 == 1)
                {
                    K.A[i].BackColor = Color.GhostWhite;
                }
                else if((i/8 + i%8)%2 == 0)
                {
                    K.A[i].BackColor = Color.DarkSeaGreen;
                }
            }
            if(move%2 == 1 && br == 1)
            {
                var Wh = W.A.Find(w => w.x == x && w.y == y);
                if(Wh == null)
                {
                    var PM1 = PM.Find(w => w[0] == x && w[1] == y);
                    if(PM1 != null)
                    {
                        
                        var Bl = B.A.Find(w => w.x == x && w.y == y);
                        Wh = W.A.Find(w => w.x == px && w.y == py);
                        Wh.x = x; Wh.y = y;
                        if(Wh is PawnW == false || (Wh is PawnW && Wh.y<8))
                        {
                            for(int i = 0; i<K.A.Count; i++)
                            {
                                if(i+1 == x + (y-1)*8)
                                {
                                    K.A[i].BackgroundImage = Wh.img;
                                }
                                if(i+1 == (py-1)*8 + px)
                                {
                                    K.A[i].BackgroundImage = null;
                                }
                            }
                            if(Wh is King && Wh.x == 7 && Wh.y == 1)
                            {
                                var K1 = Wh as King;
                                if(K1.R == 1)
                                {
                                    var R = W.A.Find(w => w.x == 8 && w.y == 1); var R1 = R as Rook;
                                    R1.x = 6; button6.BackgroundImage = R1.img; button8.BackgroundImage = null;
                                    K1.m++;
                                }
                            }
                            if(Wh is King && Wh.x == 3 && Wh.y == 1)
                            {
                                var K1 = Wh as King;
                                if(K1.L == 1)
                                {
                                    var R = W.A.Find(w => w.x == 1 && w.y == 1 && w is Rook); var R1 = R as Rook;
                                    R1.x = 4; button4.BackgroundImage = R1.img; button1.BackgroundImage = null;
                                    K1.m++;
                                }
                            }
                            if(Bl != null)
                            {
                                B.A.Remove(Bl);
                            }
                            if(Wh is Rook)
                            {
                                var R = Wh as Rook; R.m++; W.A.Remove(Wh); W.A.Add(R);
                            }
                            if(Wh is King)
                            {
                                var K1 = Wh as King; K1.m++; K1.R = 0; K1.L = 0; W.A.Remove(Wh); W.A.Add(K1);
                            }

                            move++; br = 0;
                        }
                        else
                        {
                            var Q = new Queen(x,y);
                            Q.img = Image.FromFile(@"C:\Users\dimit\Downloads\QueenW.png");
                            W.A.Remove(Wh); W.A.Add(Q);
                            for(int i = 0; i<K.A.Count; i++)
                            {
                                if(i+1 == x + (y-1)*8)
                                {
                                    K.A[i].BackgroundImage = Q.img;
                                }
                                if(i+1 == (py-1)*8 + px)
                                {
                                    K.A[i].BackgroundImage = null;
                                }
                            }
                            if(Bl != null)
                            {
                                B.A.Remove(Bl);
                            }
                            move++; br = 0;
                        }
                    }
                }
                else
                {
                    for(int i = 0; i<K.A.Count; i++)
                    {
                        if((i/8 + i%8)%2 == 1)
                        {
                            K.A[i].BackColor = Color.GhostWhite;
                        }
                        else if((i/8 + i%8)%2 == 0)
                        {
                            K.A[i].BackColor = Color.DarkSeaGreen;
                        }
                    }
                    Wh = W.A.Find(w => w.x == x && w.y == y);
                    if(Wh != null)
                    {
                        if(Wh is PawnW)
                        {
                            var P = Wh as PawnW; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Knight)
                        {
                            var P = Wh as Knight; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Bishop)
                        {
                            var P = Wh as Bishop; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Rook)
                        {
                            var P = Wh as Rook; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Queen)
                        {
                            var P = Wh as Queen; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is King)
                        {
                            var P = Wh as King; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                    }
                }
            }
            
            if(move%2 == 0 && br == 1)
            {
                var Wh = B.A.Find(w => w.x == x && w.y == y);
                if(Wh == null)
                {
                    var PM1 = PM.Find(w => w[0] == x && w[1] == y);
                    if(PM1 != null)
                    {
                        var Bl = W.A.Find(w => w.x == x && w.y == y);
                        Wh = B.A.Find(w => w.x == px && w.y == py);
                        Wh.x = x; Wh.y = y;
                        if(Wh is Rook)
                        {
                            Wh = Wh as Rook;
                        }
                        if(Wh is PawnB == false || (Wh.y>1))
                        {
                            for(int i = 0; i<K.A.Count; i++)
                            {
                                if(i+1 == x + (y-1)*8)
                                {
                                    K.A[i].BackgroundImage = Wh.img;
                                }
                                if(i+1 == (py-1)*8 + px)
                                {
                                    K.A[i].BackgroundImage = null;
                                }
                            }
                            if(Wh is King && Wh.x == 7 && Wh.y == 8)
                            {
                                var K1 = Wh as King;
                                if(K1.R == 1)
                                {
                                    var R = B.A.Find(w => w.x == 8 && w.y == 8 && w is Rook); var R1 = R as Rook;
                                    //!!!!!!!!
                                    R1.x = 6; button62.BackgroundImage = R1.img; button64.BackgroundImage = null;
                                    K1.m++;
                                }
                            }
                            if(Wh is King && Wh.x == 3 && Wh.y == 8)
                            {
                                var K1 = Wh as King;
                                if(K1.L == 1)
                                {
                                    var R = B.A.Find(w => w.x == 1 && w.y == 8); var R1 = R as Rook;
                                    R1.x = 4; button60.BackgroundImage = R1.img; button57.BackgroundImage = null;
                                    K1.m++;
                                }
                            }
                            
                            if(Bl != null)
                            {
                                W.A.Remove(Bl);
                            }
                            if(Wh is Rook)
                            {
                                var R = Wh as Rook; R.m++; B.A.Remove(Wh); B.A.Add(R);
                            }
                            if(Wh is King)
                            {
                                var K1 = Wh as King; K1.m++; B.A.Remove(Wh); B.A.Add(K1);
                            }
                            move++; br = 0;
                        }
                        else
                        {
                            var Q = new Queen(x,y);
                            Q.img = Image.FromFile(@"C:\Users\dimit\Downloads\QueenB.png");
                            B.A.Remove(Wh); B.A.Add(Q);
                            for(int i = 0; i<K.A.Count; i++)
                            {
                                if(i+1 == x + (y-1)*8)
                                {
                                    K.A[i].BackgroundImage = Q.img;
                                }
                                if(i+1 == (py-1)*8 + px)
                                {
                                    K.A[i].BackgroundImage = null;
                                }
                            }
                            if(Bl != null)
                            {
                                W.A.Remove(Bl);
                            }
                            move++; br = 0;
                        }
                    }
                }
                else
                {
                    for(int i = 0; i<K.A.Count; i++)
                    {
                        if((i/8 + i%8)%2 == 1)
                        {
                            K.A[i].BackColor = Color.GhostWhite;
                        }
                        else if((i/8 + i%8)%2 == 0)
                        {
                            K.A[i].BackColor = Color.DarkSeaGreen;
                        }
                    }
                    Wh = B.A.Find(w => w.x == x && w.y == y);
                    if(Wh != null)
                    {
                        if(Wh is PawnB)
                        {
                            var P = Wh as PawnB; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Knight)
                        {
                            var P = Wh as Knight; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Bishop)
                        {
                            var P = Wh as Bishop; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Rook)
                        {
                            var P = Wh as Rook; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is Queen)
                        {
                            var P = Wh as Queen; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                        else if(Wh is King)
                        {
                            var P = Wh as King; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                        }
                    }
                }
            }
            
            else if(move%2 == 1 && br == 0)
            {
                var Wh = W.A.Find(w => w.x == x && w.y == y);
                if(Wh != null)
                {
                    if(Wh is PawnW)
                    {
                        var P = Wh as PawnW; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Wh is Knight)
                    {
                        var P = Wh as Knight; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Wh is Bishop)
                    {
                        var P = Wh as Bishop; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Wh is Rook)
                    {
                        var P = Wh as Rook; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Wh is Queen)
                    {
                        var P = Wh as Queen; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Wh is King)
                    {
                        var P = Wh as King; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                }
                br++;
            }
            
            
            
            else if(move%2 == 0 && br == 0)
            {
                var Bl = B.A.Find(w => w.x == x && w.y == y);
                if(Bl != null)
                {
                    if(Bl is PawnB)
                    {
                        var P = Bl as PawnB; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Bl is Knight)
                    {
                        var P = Bl as Knight; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);}; px = x; py = y;
                    }
                    else if(Bl is Bishop)
                    {
                        var P = Bl as Bishop; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Bl is Rook)
                    {
                        var P = Bl as Rook; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Bl is Queen)
                    {
                        var P = Bl as Queen; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    else if(Bl is King)
                    {
                        var P = Bl as King; PM = P.PM(W,B); if(P.x != px || P.y != py){Colors(PM,K);} px = x; py = y;
                    }
                    br++;
                }
            }
            px = x; py = y;
            return;
        }
        
        
        
        
        
        void Button1Click(object sender, EventArgs e)
        {
            int x = 1; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            //label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
            foreach(Piece P in B.A)
            {
            	label1.Text += P.x + " " + P.y + "\n";
            }
        }
        void Button2Click(object sender, EventArgs e)
        {
            int x = 2; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button3Click(object sender, EventArgs e)
        {
            int x = 3; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button4Click(object sender, EventArgs e)
        {
            int x = 4; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button5Click(object sender, EventArgs e)
        {
            int x = 5; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button6Click(object sender, EventArgs e)
        {
            int x = 6; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button7Click(object sender, EventArgs e)
        {
            int x = 7; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button8Click(object sender, EventArgs e)
        {
            int x = 8; int y = 1;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button9Click(object sender, EventArgs e)
        {
            int x = 1; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button10Click(object sender, EventArgs e)
        {
            int x = 2; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button11Click(object sender, EventArgs e)
        {
            int x = 3; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button12Click(object sender, EventArgs e)
        {
            int x = 4; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button13Click(object sender, EventArgs e)
        {
            int x = 5; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button14Click(object sender, EventArgs e)
        {
            int x = 6; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button15Click(object sender, EventArgs e)
        {
            int x = 7; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button16Click(object sender, EventArgs e)
        {
            int x = 8; int y = 2;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        
        void Button17Click(object sender, EventArgs e)
        {
            int x = 1; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button18Click(object sender, EventArgs e)
        {
            int x = 2; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button19Click(object sender, EventArgs e)
        {
            int x = 3; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button20Click(object sender, EventArgs e)
        {
            int x = 4; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button21Click(object sender, EventArgs e)
        {
            int x = 5; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button22Click(object sender, EventArgs e)
        {
            int x = 6; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button23Click(object sender, EventArgs e)
        {
            int x = 7; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button24Click(object sender, EventArgs e)
        {
            int x = 8; int y = 3;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button25Click(object sender, EventArgs e)
        {
            int x = 1; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button26Click(object sender, EventArgs e)
        {
            int x = 2; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button27Click(object sender, EventArgs e)
        {
            int x = 3; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button28Click(object sender, EventArgs e)
        {
            int x = 4; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button29Click(object sender, EventArgs e)
        {
            int x = 5; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button30Click(object sender, EventArgs e)
        {
            int x = 6; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button31Click(object sender, EventArgs e)
        {
            int x = 7; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button32Click(object sender, EventArgs e)
        {
            int x = 8; int y = 4;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        
        void Button33Click(object sender, EventArgs e)
        {
            int x = 1; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button34Click(object sender, EventArgs e)
        {
            int x = 2; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button35Click(object sender, EventArgs e)
        {
            int x = 3; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button36Click(object sender, EventArgs e)
        {
            int x = 4; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button37Click(object sender, EventArgs e)
        {
            int x = 5; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button38Click(object sender, EventArgs e)
        {
            int x = 6; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button39Click(object sender, EventArgs e)
        {
            int x = 7; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button40Click(object sender, EventArgs e)
        {
            int x = 8; int y = 5;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button41Click(object sender, EventArgs e)
        {
            int x = 1; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button42Click(object sender, EventArgs e)
        {
            int x = 2; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button43Click(object sender, EventArgs e)
        {
            int x = 3; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button44Click(object sender, EventArgs e)
        {
            int x = 4; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button45Click(object sender, EventArgs e)
        {
            int x = 5; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button46Click(object sender, EventArgs e)
        {
            int x = 6; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button47Click(object sender, EventArgs e)
        {
            int x = 7; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button48Click(object sender, EventArgs e)
        {
            int x = 8; int y = 6;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        
        void Button49Click(object sender, EventArgs e)
        {
            int x = 1; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button50Click(object sender, EventArgs e)
        {
            int x = 2; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button51Click(object sender, EventArgs e)
        {
            int x = 3; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button52Click(object sender, EventArgs e)
        {
            int x = 4; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button53Click(object sender, EventArgs e)
        {
            int x = 5; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button54Click(object sender, EventArgs e)
        {
            int x = 6; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button55Click(object sender, EventArgs e)
        {
            int x = 7; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button56Click(object sender, EventArgs e)
        {
            int x = 8; int y = 7;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button57Click(object sender, EventArgs e)
        {
            int x = 1; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button58Click(object sender, EventArgs e)
        {
            int x = 2; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button59Click(object sender, EventArgs e)
        {
            int x = 3; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button60Click(object sender, EventArgs e)
        {
            int x = 4; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button61Click(object sender, EventArgs e)
        {
            int x = 5; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button62Click(object sender, EventArgs e)
        {
            int x = 6; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button63Click(object sender, EventArgs e)
        {
            int x = 7; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
        void Button64Click(object sender, EventArgs e)
        {
            int x = 8; int y = 8;
            POS(ref x, ref y,ref move,ref br1,ref W,ref B,ref PM,ref px,ref py,K);
            label1.Text += move + " " + br1 + " " + px + " " + py + "\n";
        }
	}
}
