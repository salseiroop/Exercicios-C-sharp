Episodio ep1 = new(2, 50, "Técnincas de facilitação");
ep1.AdicionarConvidaos("Maria, Gustavo, Bento");

Episodio ep2 = new(1, 67, "Técnincas de Aprendizado");
ep2.AdicionarConvidaos("José, Alan");

Podcast podcast = new("PodPah", "Salseiro", 7);
podcast.adicionarEpisodio(ep1);
podcast.adicionarEpisodio(ep2);
podcast.ExibirDetalhes();