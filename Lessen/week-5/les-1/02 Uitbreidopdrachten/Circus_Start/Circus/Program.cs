using Circus;

var artiesten = new List<Artiest>
{
                new Goochelaar(),
                new Clown(),
                new Acrobaat()
            };

var circus = new Circus();

foreach (var artiest in artiesten)
{
    circus.SubscribeArtiest(artiest.VoerActUit);
}

circus.VoerActsUit(VoorstellingMoment.opening);
circus.VoerActsUit(VoorstellingMoment.naPauze);
circus.VoerActsUit(VoorstellingMoment.slot);
