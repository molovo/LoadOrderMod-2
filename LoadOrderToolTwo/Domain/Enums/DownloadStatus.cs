﻿namespace LoadOrderToolTwo.Domain.Enums;

public enum DownloadStatus
{
    None,
    OK,
    Unknown,
    OutOfDate,
    NotDownloaded,
    PartiallyDownloaded,
    Removed,
}

public enum DownloadStatusFilter
{
    Any,
    None,
    OK,
    Unknown,
    OutOfDate,
    NotDownloaded,
    PartiallyDownloaded,
    Removed,
}