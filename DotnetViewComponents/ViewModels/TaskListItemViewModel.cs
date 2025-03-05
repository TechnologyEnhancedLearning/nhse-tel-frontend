namespace DotnetViewComponents.ViewModels
{
    public class TaskListItemViewModel
    {
        /// <summary>
        /// Creates a new instance of the <see cref="TaskListItemViewModel"/> class.
        /// STATE: Choose between "Completed", "Incomplete" and "Cannot start yet".
        /// STATESTYLE: The style should match the state. (e.g. "TaskStateStyle.INCOMPLETE" for "Incomplete", "TaskStateStyle.COMPLETED" for "Completed", "TaskStateStyle.UNSTARTED" for "Cannot start yet")
        /// </summary>
        /// <param name="state">Choose between "Completed", "Incomplete" and "Cannot start yet".</param>
        /// <param name="stateStyle">The style should match the state. (e.g. "TaskStateStyle.INCOMPLETE" for "Incomplete", "TaskStateStyle.COMPLETED" for "Completed", "TaskStateStyle.UNSTARTED" for "Cannot start yet")</param>
        public TaskListItemViewModel(
            string id,
            string name,
            string url,
            string state,
            TaskStateStyle stateStyle,
            string hintText)
        {
            Id = id;
            Name = name;
            Url = url;
            State = state;
            StateStyle = stateStyle;
            HintText = hintText;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string State { get; set; }

        public TaskStateStyle StateStyle { get; set; }

        public string HintText { get; set; }
    }


    public enum TaskStateStyle
    {
        COMPLETED,
        INCOMPLETE,
        UNSTARTED
    }
}
