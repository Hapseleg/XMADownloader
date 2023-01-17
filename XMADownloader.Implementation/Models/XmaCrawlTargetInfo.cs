﻿using System.Collections.Generic;
using System.IO;
using UniversalDownloaderPlatform.Common.Interfaces.Models;

namespace XMADownloader.Implementation.Models
{
    public class XmaCrawlTargetInfo : ICrawlTargetInfo
    {
        private static readonly HashSet<char> InvalidFilenameCharacters;

        static XmaCrawlTargetInfo()
        {
            InvalidFilenameCharacters = new HashSet<char>(Path.GetInvalidFileNameChars());
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string SaveDirectory => ""; //set to empty because we download into separate directories based on mod author id
    }
}
