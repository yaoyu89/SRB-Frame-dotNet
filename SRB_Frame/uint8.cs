﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System//SRB_CTR.nsByteExtensions
{
    public static class Expand_Byte
    {
        static public string ToHexSt(this byte b)
        {
            char[] ca = new char[2];
            ca[0] = (char)(b / 16);
            if (ca[0] > 9)
            {
                ca[0] += (char)('A' - 10);
            }
            else
            {
                ca[0] += '0';
            }
            ca[1] = (char)(b % 16);
            if (ca[1] > 9)
            {
                ca[1] += (char)('A' - 10);
            }
            else
            {
                ca[1] += '0';
            }
            return new string(ca, 0, 2);
        }

       static public int enterRound(this int i,int min ,int max)
        {
            if (i >= max)
            {
                return max;
            }
            if(i<=min)
            {
                return min;
            }
            return i;
        }
        static public string AsByteToHexSt(this int i)
        {
            byte b = (byte)i;
            return b.ToHexSt();
        }
        static public string ToHexSt(this byte[] ba, int len = -1)
       {
           if (ba == null)
           {
               return "<null>";
           }
           if (len == -1)
           {
               len = ba.Length;
               if (len == 0)
               {
                   return "<empty>";
               }
           }
           string s = "";
           for(int i = 0;i<len;i++)
           {
               byte b = ba[i];
               s += b.ToHexSt() + ' ';
           }
           return s;
       }

        static public string ToArrayString(this byte[] ba, int len = -1)
        {
            if (ba == null)
            {
                return "{}";
            }
            if (len == -1)
            {
                len = ba.Length;
                if (len == 0)
                {
                    return "{};";
                }
            }
            string s = "";
            s += "{";
            int i = 0;
            while (true)
            {
                byte b = ba[i];
                //  s += "0x" + b.ToHexSt();
                s += b.ToString();
                i++;
                if (i < len)
                {
                    s += ",";
                }
                else
                {
                    s += "};";
                    return s;
                }
            }
        }
        static public bool bit(this byte b, int diff)
        {
            if ((b & (1 << diff)) == 0)
                return false;
            else
                return true;
        }
        static public byte writeBit(ref this byte b , int diff, bool value)
        {
            if (value)
                b |= (byte)(1 << diff);
            else
                b &= (byte)~(1 << diff);
            return b;
        }

        static public string ToPythonTuple(this byte[] ba, int len = -1)
        {
            if (ba == null)
            {
                return "('null')";
            }
            if (len == -1)
            {
                len = ba.Length;
                if (len == 0)
                {
                    return "('empty')";
                }
            }
            string s = "";
            for (int i = 0; i < len; i++)
            {
                byte b = ba[i];
                s += "0x"+b.ToHexSt() + ',';
            }
            return "("+s+")";
        }
        static public byte[] SubArray(this byte[] ba, int len)
       {
           if (ba == null)
           {
               return null;
           }
           byte[] nba = new byte[len];
           for (int i = 0; i < len; i++)
           {
               nba[i] = ba[i];
           }
           return nba;
       }
       static public byte ByteLow(this ushort u16)
       {
           return (byte)(u16);
       }
       static public byte ByteHigh(this ushort u16)
       {
           return (byte)(u16 >> 8);
       }
       static public ushort GetUint16(this byte[] b, int num)
       {
           return (ushort)((int)b[num] + (((int)b[num + 1]) << 8));
       }
        public static byte[] ToByteAsCArroy(this string st,out string error)
        {
           // TODO:
            //change inpot 0x
            int begin = st.IndexOf('{');
            int end = st.IndexOf('}');
            if (begin < 0)
            {
                error = "Miss char '{'";
                return null;
            }
            if (end < 0)
            {
                error = "Miss char '}'";
                return null;
            }
            if (end <= begin)
            {
                error = "No arror {...}";
                return null;

            }
            st = st.Substring(begin + 1, end - begin - 1);
            st.Replace(" ", "");
            st.Replace(";", "");
            st.Replace("\n", "");
            st.Replace("\r", "");
            st.Replace("\t", "");
            string[] sta = st.Split(',');
            byte[] b = new byte[sta.Length];
            for (int i = 0; i < sta.Length; i++)
            {//调试错误 这里应该处理空数组
                if (sta[i].Length == 0)
                {
                    error = "Number "+i+" is missing";
                    return null;
                }
                int provider;
                if ((sta[i].ToCharArray()[0] == '0') && (sta[i].Length > 1))
                {
                    if (sta[i].ToCharArray()[1] == 'x')
                    {
                        provider = 16;
                        sta[i] = sta[i].Substring(2);
                    }
                    else
                    {
                        provider = 8;
                        sta[i] = sta[i].Substring(1);
                    }
                }
                else
                {
                    provider = 10;
                }
                try
                {
                    b[i] = System.Convert.ToByte(sta[i], provider);
                }
                catch
                {
                    error = "\"" + sta[i] + "\"" + " is not a number";
                    return null;
                }
            }
            error = "done";
            return b;
        }
    }
}
