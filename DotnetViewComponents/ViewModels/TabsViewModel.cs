using Microsoft.AspNetCore.Html;

namespace DotnetViewComponents.ViewModels
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TabsViewModel"/> class.
    /// </summary>
    /// <param name="title">The title of the tab set.</param>
    /// <param name="tabsList">A list of tabs contained in the tab set.</param>
    public class TabsViewModel
    {
        public TabsViewModel(
            string title,
            List<TabViewModel> tabsList)
        {
            Title = title;
            TabsList = tabsList;
        }

        /// <summary>
        /// Gets or sets the title of the tab set.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the list of tabs in the tab set.
        /// </summary>
        public List<TabViewModel> TabsList { get; set; }

    }

    public class TabViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TabViewModel"/> class.
        /// </summary>
        /// <param name="name">The name of the tab.</param>
        /// <param name="content">A function that generates the HTML content for the tab.</param>
        /// <param name="isActive">Indicates whether the tab is currently active.</param>
        public TabViewModel(
            string name,
            Func<object, IHtmlContent> content,
            bool isActive)
        {
            Name = name;
            Content = content;
            IsActive = isActive;
        }

        /// <summary>
        /// Gets or sets the name of the tab.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a function that generates the HTML content for the tab.
        /// </summary>
        public Func<object, IHtmlContent> Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the tab is currently active.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
