namespace DotnetViewComponents.ViewModels
{
    public class TableViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewModel"/> class.
        /// </summary>
        /// <param name="title">The title of the table.</param>
        /// <param name="rows">A list of rows, where each row is a list of table columns.</param>
        /// <param name="isResponsive">Indicates whether the table should be responsive. Default is false.</param>
        /// <param name="hasNumericData">Indicates whether the table contains numeric data. Default is false.</param>
        public TableViewModel(
            string title,
            List<List<TableColumnModel>> rows,
            bool isResponsive,
            bool hasNumericData)
        {
            Title = title;
            Rows = rows;
            IsResponsive = isResponsive;
            HasNumericData = hasNumericData;
        }

        /// <summary>
        /// Gets or sets the title of the table.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the list of rows in the table, where each row is a list of table columns.
        /// </summary>
        public List<List<TableColumnModel>> Rows { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the table should be responsive.
        /// </summary>
        public bool IsResponsive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the table contains numeric data.
        /// </summary>
        public bool HasNumericData { get; set; }

    }

    public class TableColumnModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableColumnModel"/> class.
        /// </summary>
        /// <param name="header">The header text for the column.</param>
        /// <param name="column">The data for the column.</param>
        public TableColumnModel(
            string header,
            string column)
        {
            Header = header;
            Column = column;
        }

        /// <summary>
        /// Gets or sets the header text for the column.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the data for the column.
        /// </summary>
        public string Column { get; set; }
    }
}
