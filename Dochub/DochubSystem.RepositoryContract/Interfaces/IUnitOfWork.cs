﻿using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DochubSystem.RepositoryContract.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        Task<int> CompleteAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();

    }
}
