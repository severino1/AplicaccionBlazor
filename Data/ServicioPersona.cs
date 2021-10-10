using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Tarea9y10.Data
{
    public class ServicioPersona
{

    

    private PersonaDbContext dbContext;
     private readonly IWebHostEnvironment webHostEnvironment;  

    public ServicioPersona(PersonaDbContext dbContext,IWebHostEnvironment Environment)
    {
        this.dbContext = dbContext;
        this.webHostEnvironment =Environment;
    }

    public async Task<List<Persona>> VerPersonasAsync()
    {
        
        return await dbContext.personas.ToListAsync();
    
    }

    public async Task<Persona> AddPersonaAsync(Persona persona, IFileListEntry file)
    {
        try
        {
            var path = Path.Combine(webHostEnvironment.ContentRootPath,"./wwwroot/images",file.Name);
            var streamwriter = new MemoryStream();
            await file.Data.CopyToAsync(streamwriter);
            FileStream files=new FileStream(path,FileMode.Create,FileAccess.Write);
            {
                streamwriter.WriteTo(files);
                persona.img =path.Substring(path.LastIndexOf("images"));
            }
            dbContext.personas.Add(persona);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return persona;
    }

    public async Task<Persona> UpdatePersonaAsync(Persona persona, IFileListEntry file)
    {
        try
        {
            
            var PersonaExist = dbContext.personas.FirstOrDefault(p => p.PersonaId == persona.PersonaId);
            if (PersonaExist != null)
            {
            var path = Path.Combine(webHostEnvironment.ContentRootPath,"./wwwroot/images",file.Name);
            var streamwriter = new MemoryStream();
            await file.Data.CopyToAsync(streamwriter);
            FileStream files=new FileStream(path,FileMode.Create,FileAccess.Write);
            {
                streamwriter.WriteTo(files);
                persona.img =path.Substring(path.LastIndexOf("images"));
            }
                dbContext.Update(persona);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return persona;
    }

    public async Task<Persona> UpdatePersonaAsync2(Persona persona)
    {
        try
        {
            var PersonaExist = dbContext.personas.FirstOrDefault(p => p.PersonaId == persona.PersonaId);          
            if (PersonaExist != null)
            {
                dbContext.Update(persona);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return persona;
    }

    public async Task DeletePersonaAsync(Persona persona)
    {
        try
        {
            dbContext.personas.Remove(persona);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

}
}