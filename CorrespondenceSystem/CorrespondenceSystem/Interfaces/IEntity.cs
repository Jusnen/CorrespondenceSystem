﻿namespace CorrespondenceSystem.Interfaces
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }

    }
}