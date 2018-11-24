﻿namespace FMLibrary.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Duelist
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Duelist(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int[] Deck { get; set; } = new int[722];
        /// <summary>
        /// 
        /// </summary>
        public Rank Drop { get; set; } = new Rank();
    }
}
