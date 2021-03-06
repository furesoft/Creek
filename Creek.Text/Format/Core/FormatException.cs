﻿namespace Creek.Text.Format.Core
{
    using System;

    using Lib.Format.Core.Parsing;

    /// <summary>
    /// An exception caused by either a parsing issue
    /// or an unhandled error in attempting to output the format.
    /// </summary>
    public class FormatException : Exception
    {
        public FormatException(FormatItem errorItem, Exception formatException, int index)
        {
            this.Format = errorItem.baseString;
            this.FormatSoFar = null;
            this.ErrorItem = errorItem;
            this.Issue = formatException.Message;
            this.Index = index;
        }
        public FormatException(FormatItem errorItem, string issue, int index)
        {
            this.Format = errorItem.baseString;
            this.FormatSoFar = null;
            this.ErrorItem = errorItem;
            this.Issue = issue;
            this.Index = index;
        }

        public string Format { get; private set; }
        public Lib.Format.Core.Parsing.Format FormatSoFar { get; private set; }
        public FormatItem ErrorItem { get; private set; }
        public string Issue { get; private set; }
        public int Index { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format("Error parsing format string: {0} at {1}\n{2}\n{3}",
                                     this.Issue,
                                     this.Index,
                                     this.Format,
                                     new String('-', this.Index) + "^");
            }
        }
    }
}
