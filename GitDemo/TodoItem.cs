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
        /// <summary>
        /// Kennzeichnet den Status eines Eintrags
        /// </summary>        
        public bool IsDone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
