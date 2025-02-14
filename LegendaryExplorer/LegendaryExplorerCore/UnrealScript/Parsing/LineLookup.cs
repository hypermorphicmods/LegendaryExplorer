﻿using System.Collections.Generic;

namespace LegendaryExplorerCore.UnrealScript.Parsing
{
    public sealed class LineLookup
    {
        public readonly List<int> Lines;

        public LineLookup(List<int> lines)
        {
            this.Lines = lines;
        }

        public int GetLineFromCharIndex(int charIndex)
        {
            int arrIdx = Lines.BinarySearch(charIndex);
            
            if (arrIdx < 0)
            {
                arrIdx = ~arrIdx;
                if (arrIdx == 0)
                {
                    arrIdx++;
                }
            }
            else
            {
                arrIdx++;
            }

            return arrIdx;
        }

        public int GetColumnFromCharIndex(int charIndex)
        {
            return charIndex - Lines[GetLineFromCharIndex(charIndex) - 1];
        }
    }
}