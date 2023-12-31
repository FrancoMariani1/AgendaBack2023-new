﻿using AgendaBack2023.Data;
using AgendaBack2023.Data.Repository.Interfaces;
using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace OtraAgendaApi.Data.Repository.Implementations
    {
        public class ContactRepository : IContactRepository
        {
            private readonly AgendaBackContext _context;
            private readonly IMapper _mapper;


            public ContactRepository(AgendaBackContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public Contact GetContactById(int id)
        {
                return _context.Contacts
                .Include(c => c.location)
                .Single(c => c.id == id);
                
            }
           

            public List<Contact> GetAllByUser(int id)
            {
                return _context.Contacts.Where(c => c.Userid == id)
                .Include(c => c.location)
                .ToList();
            }

            public Contact Create(CreateAndUpdateContactDTO dto, int id)
            {
                Contact contact = _mapper.Map<Contact>(dto);
                contact.Userid = id;
                _context.Contacts.Add(contact);
                _context.SaveChanges();

                return contact;

            }
          
            public Contact Update(CreateAndUpdateContactDTO dto)
            {
                 //contact = _context.Contacts.Single(c => c.id == dto.id);
                Contact contact = _mapper.Map<Contact>(dto);
                _context.Contacts.Update(contact);
                
                _context.SaveChanges();

                return contact;
            }

            public void Delete(int id)
            {
                _context.Contacts.Remove(_context.Contacts.Single(c => c.id == id));
                _context.SaveChanges();
            }
    }
    }


