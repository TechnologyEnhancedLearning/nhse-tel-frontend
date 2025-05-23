﻿namespace DotnetViewComponents.ViewModels.NHS
{
    using System.Collections.Generic;

    public class ErrorSummaryViewModel
    {
        public ErrorSummaryViewModel(List<ErrorSummaryListItem> errors)
        {
            Errors = errors;
        }

        public List<ErrorSummaryListItem> Errors { get; set; }
    }

    public class ErrorSummaryListItem
    {
        public ErrorSummaryListItem(string key, string errorMessage)
        {
            Key = key;
            ErrorMessage = errorMessage;
        }

        public string Key { get; set; }

        public string ErrorMessage { get; set; }
    }
}
