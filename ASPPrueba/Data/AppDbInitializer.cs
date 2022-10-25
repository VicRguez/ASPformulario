using ASPPrueba.Models;

namespace ASPPrueba.Data
{
    public class AppDbInitializer
    {


        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDBContext>();

                context.Database.EnsureCreated();

                if (!context.preguntas.Any())
                {
                    context.preguntas.AddRange(new List<Pregunta>()
                    {

                        //Cinema
                        new Pregunta()
                        {
                            Titulo = "PREGUNTA2",
                            TextoPregunta = "CUAL ES LA RESPUESTA DEL TODO",
                            PosiblesRespuestas = "42",
                            TipoPregunta = ""
                        },
                        new Pregunta()
                        {
                            Titulo = "PREGUNTA5",
                            TextoPregunta = "CUANTOS TRABAJADORES TIENES",
                            PosiblesRespuestas = "",
                            TipoPregunta = ""
                        },
                        new Pregunta()
                        {
                            Titulo = "PREGUNTA6",
                            TextoPregunta = "DE QUE COLOR ES EL CIELO",
                            PosiblesRespuestas = "",
                            TipoPregunta = ""
                        }
                    });

                    context.SaveChanges();

                }

            }

        }

    }
}