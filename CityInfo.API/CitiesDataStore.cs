using CityInfo.API.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="Recife",
                    Description="Frevo e carnaval",
                    PointsOfInterest= new List<PointOfInterestDto>(){
                    new PointOfInterestDto(){
                            Id=1,
                            Name="Marco Zero",
                            Description="O marco zero da cidade"
                        },
                     new PointOfInterestDto(){
                            Id=2,
                            Name="Recife Antigo",
                            Description="Parte antiga da cidade"
                        }
                    }
                },
                 new CityDto()
                {
                    Id=2,
                    Name="Olinda",
                    Description="Cidade do CArnaval",
                    PointsOfInterest= new List<PointOfInterestDto>(){
                    new PointOfInterestDto(){
                            Id=3,
                            Name="Ladeiras",
                            Description="Ladeiras de Olinda"
                        }
                    }
                },
                  new CityDto()
                {
                    Id=3,
                    Name="São Paulo",
                    Description="Predios, trabalho ",
                    PointsOfInterest= new List<PointOfInterestDto>(){
                    new PointOfInterestDto(){
                            Id=4,
                            Name="Avanida Paulista",
                            Description="Coração economico da cidade"
                        }
                    }
                },
                   new CityDto()
                {
                    Id=4,
                    Name="Rio de Janeiro",
                    Description="Pão de Açucar",
                    PointsOfInterest= new List<PointOfInterestDto>(){
                    new PointOfInterestDto(){
                            Id=5,
                            Name="Pão de Açucar",
                            Description="Cartão postal da cidade"
                        }
                    }
                },
                    new CityDto()
                {
                    Id=5,
                    Name="Triunfo",
                    Description="Cidade do Frio",
                    PointsOfInterest= new List<PointOfInterestDto>(){
                    new PointOfInterestDto(){
                            Id=6,
                            Name="Pico do papagaio",
                            Description="Ponto mais alto de Pernambuco"
                        }
                    }
                },

            };
        }
    }
}
