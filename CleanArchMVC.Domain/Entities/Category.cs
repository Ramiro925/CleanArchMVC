﻿using CleanArchMVC.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Domain.Entities
{
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }
        public Category(string name, int id)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name);
        }
        public void Update(string name)
        {
            ValidateDomain(name);
        }
        public ICollection<Product> Products { get; set; }
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required.");
            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters.");
            DomainExceptionValidation.When(name.Length > 100,
                "Invalid name, too long, maximum 100 characters.");

            Name = name;
        }
    }
}