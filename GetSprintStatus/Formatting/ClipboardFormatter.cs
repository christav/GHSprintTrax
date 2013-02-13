﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace GetSprintStatus.Formatting
{
    /// <summary>
    /// Places statistics onto the clipboard in a format ready to
    /// paste into sprint tracking spreadsheet
    /// </summary>
    class ClipboardFormatter : IFormatter
    {
        public void Visit(BurndownStats stats)
        {
            string text = string.Format("{0}\t{1}\t{2}\t{3}\t{4}",
                stats.DevRemaining, stats.TestRemaining,
                stats.InProgress,
                stats.ReadyForTest, stats.InTest);

            Clipboard.SetText(text, TextDataFormat.Text);
        }
    }
}
