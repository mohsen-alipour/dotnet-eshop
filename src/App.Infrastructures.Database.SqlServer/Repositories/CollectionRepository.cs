﻿using System;
using App.Infrastructures.Database.SqlServer.Data;

public class CollectionRepository
{
    private readonly AppDbContext _shopDB;

    public CollectionRepository(AppDbContext appDbContext)
    {
        this._shopDB = appDbContext;
    }


    public void AddCollection(App.Infrastructures.Database.SqlServer.Entities.Collection item)
    {
        _shopDB.Collections.Add(item);
        _shopDB.SaveChanges();

    }

    public List<App.Infrastructures.Database.SqlServer.Entities.Collection> GetAllCollection()
    {
        return _shopDB.Collections.ToList();
    }


    public void DelteCollection(App.Infrastructures.Database.SqlServer.Entities.Collection item)
    {
        _shopDB.Collections.Remove(item);
        _shopDB.SaveChanges();
    }
}
