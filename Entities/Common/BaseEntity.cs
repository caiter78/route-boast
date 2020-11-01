﻿namespace Entities.Common
{
    public interface IEntity
    {
    }
    
    public abstract class BaseEntity<TKey> : IEntity
    {
        public TKey Id { get; set; }
    }
}