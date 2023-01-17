﻿using System;
using System.Collections.Generic;
using System.Text;
using UniversalDownloaderPlatform.Common.Enums;
using UniversalDownloaderPlatform.Common.Helpers;
using UniversalDownloaderPlatform.Common.Interfaces.Models;
using UniversalDownloaderPlatform.DefaultImplementations.Models;

namespace XMADownloader.Implementation.Models
{
    public record XMADownloaderSettings : UniversalDownloaderPlatformSettings
    {
        public bool SaveDescriptions { get; init; }

        public bool SaveHtml { get; init; }

        /// <summary>
        /// Create a new directory for every post and store files of said post in that directory
        /// </summary>
        //public bool IsUseSubDirectories { get; init; }

        /// <summary>
        /// Pattern used to generate directory name if UseSubDirectories is enabled
        /// </summary>
        public string SubDirectoryPattern { get; init; }

        /// <summary>
        /// Subdirectory names will be truncated to this length
        /// </summary>
        public int MaxSubdirectoryNameLength { get; init; }

        /// <summary>
        /// Filenames will be truncated to this length
        /// </summary>
        public int MaxFilenameLength { get; init; }

        /// <summary>
        /// Fallback to using sha256 hash and Content-Type for filenames if Content-Disposition fails
        /// </summary>
        public bool FallbackToContentTypeFilenames { get; init; }

        public XMADownloaderSettings()
        {
            SaveDescriptions = true;
            SaveHtml = true;
            //IsUseSubDirectories = false;
            SubDirectoryPattern = "[%ModId%] %PublishedAt% %PostTitle%";
            FallbackToContentTypeFilenames = false;
            MaxFilenameLength = 100;
            MaxSubdirectoryNameLength = 100;
        }
    }
}
