namespace GitDemo
{
    /// <summary>
    /// Ein Todo-Eintrag
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// Die Id des Eintrags
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Der Titel des Eintrags
        /// </summary>
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}
