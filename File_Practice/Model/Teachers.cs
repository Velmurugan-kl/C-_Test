namespace File_Practice.Model
{
    /// <summary>
    /// Teachers class
    /// </summary>
    internal class Teachers
    {
        public Teachers(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Gets or sets Teacher ID
        /// </summary>
        /// <value>Teacher ID</value>
        public int Id {  get; set; }

        /// <summary>
        /// Gets or sets Teacher name
        /// </summary>
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id},{Name}";
        }
    }
}
