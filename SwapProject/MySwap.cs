﻿namespace SwapProject{
    public class SwapMethod{
        public static void Swap <T> (ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
    }
}