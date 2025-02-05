﻿using Network.Data.Repository.Impl;
using Network.Data.Repository.Interfaces;
using Network.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network.Data.Context;
using Network.Data.UoW;

namespace Network.Data.Repository.Impl
{
    public class FileAttachmentRepository : Repository<FileAttachment, Guid>, IFileAttachmentRepository
    {
        public FileAttachmentRepository(UnitOfWork _context) : base(_context)
        {
        }
    }
}
