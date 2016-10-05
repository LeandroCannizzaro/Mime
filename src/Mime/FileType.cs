﻿namespace HeyRed.MimeGuesser
{
    public class FileType
    {
        public string MimeType { get; }
        public string Extension { get; }

        public FileType(string mime, string extension)
        {
            MimeType = mime;
            Extension = extension;
        }
    }
}
