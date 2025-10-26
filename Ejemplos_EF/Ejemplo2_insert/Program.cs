

using EncuestasData;
using EncuestasData.Models;


var obj = new Respuesta
{
    Email = "camila@gmail.com",
    Camina = false,
    UsaTransportePublico = true,
    UsaTransportePrivado = false,
    DistanciaASuDestino = 12.5M
};

using (var db = new AppDbContext())
{
    db.Respuestas.Add(obj);
    db.SaveChanges();
}

