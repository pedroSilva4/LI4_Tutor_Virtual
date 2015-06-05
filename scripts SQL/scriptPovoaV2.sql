use NomesHistoriaDB;

insert into Personagens values('D. Afonso Henriques',1,'Assets/sprites/dafh/Afonso_1.png');
insert into Personagens values('Luis de Camoes',2,'Assets/sprites/ldc/camoes_1.png');

-- aulas
insert into Aulas values(1,1,1,1,1,1,1,'D. Afonso Henriques',1,'Afonso Henriques');
insert into Aulas values(2,1,1,1,1,1,1,'D. Afonso Henriques',2,'Batalha de S. Mamede');
insert into Aulas values(3,1,1,1,1,1,1,'D. Afonso Henriques',3,'Batalha de Ourique');
insert into Aulas values(4,1,1,1,1,1,1,'D. Afonso Henriques',4,'Últimas Conquistas');
insert into Aulas values(5,1,1,1,1,1,1,'D. Afonso Henriques',5,'Reino de Portugal');

select * from Aulas;

insert into AmbientesDeAula values('Guimaraes','Assets/Backgrounds_ops/gmr.jpg');
insert into AmbientesDeAula values('25 de Abril','Assets/Backgrounds_ops/25ABR74.jpg');
insert into AmbientesDeAula values('Descobrimentos','/Assets/Backgrounds_ops/descobrimentos.jpg');


--insert into Utilizadores values('pedrinho','1234',0,1,1,1,1,1,1,'D. Afonso Henriques','guimaraes');
--insert into Utilizadores values('filipinho','1234',0,1,1,1,1,1,1,'D. Afonso Henriques','guimaraes');
--insert into Utilizadores values('carlitos','1234',0,1,1,1,1,1,1,'D. Afonso Henriques','25 de Abril');

-- Aula 1 - afonso henriques Inserir apresentacao e a sua multimedia
-- apresentacao 1
insert into Apresentacoes values(1,1,'imagem',1,1);
insert into Multimedia values(1,1,1,1,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg1.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg1.png');
insert into Multimedia values(2,1,1,2,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg2.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg2.png');
insert into Multimedia values(3,1,1,3,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg3.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg3.png');
insert into Multimedia values(4,1,1,4,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg4.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap1/AfonsoImg4.png');
-- apresentacao 2
insert into Apresentacoes values(2,1,'video',1,1);
insert into Multimedia values(5,2,1,1,NULL,'Assets/etapas/dafh/1 - Afonso Henriques/Video/Ap1/Afonso1.webm');
-- apresentacao 3
insert into Apresentacoes values(3,1,'imagem',1,1);
insert into Multimedia values(6,3,1,1,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img1.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img1.png');
insert into Multimedia values(7,3,1,2,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img2.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img2.png');
insert into Multimedia values(8,3,1,3,'Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img3.txt','Assets/etapas/dafh/1 - Afonso Henriques/Imagem/Ap2/img3.png');

-- ajudas aula 1
insert into Ajudas values(1,1,'Foi o fundador do nosso País','Quem foi D.Afonso Henriques','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/quemFoiDAFH.wav');
insert into Ajudas values(2,1,'No ano de 1283','Em que ano nasceu D.Afonso Henriques','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/emQueAnoNasceuDAFH.wav');
insert into Ajudas values(3,1,'Conde Dom Henrique','Quem foi o pai de D. Afonso Henriques?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/paiDAFH.wav');
insert into Ajudas values(4,1,'Dona Teresa','Quem foi a mãe de D. Afonso Henriques?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/maeDAFH.wav');
insert into Ajudas values(5,1,'D. Afonso XI','O nome de Afonso de D. Afonso Henriques foi dado em honra de quem?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/emHonraDe.wav');
insert into Ajudas values(6,1,'Para ser cavaleiro','Para que foi treinado D. Afonso Henriques na sua infância?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/treinadoPara.wav');
insert into Ajudas values(7,1,'Catedral de Zamora','Em que catedral se tornou cavaleiro D. Afonso Henriques?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/ondeCavaleiro.wav');
insert into Ajudas values(8,1,'Leão e Castela','Afonso XI, avó D. Afonso Henriques, era rei de?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/avoReiDe.wav');
insert into Ajudas values(9,1,'D. Teresa','Quem foi a esposa de D.Henrique, pai de D. Afonso Henriques?','Assets/etapas/dafh/1 - Afonso Henriques/Ajudas/esposaDoPai.wav');
-- perguntas aula1
-- insert into Perguntas values(cod,aula,'pergunta','resposta','errada1','errada2','errada3');
insert into Perguntas values(1,1,'Em que ano nasceu D. Afonso Henriques?','1109','1009','1149','2009');
insert into Perguntas values(2,1,'Onde nasceu D. Afonso Henriques?','Condado Portucalense','Espanha','Portugal','Castela');
insert into Perguntas values(3,1,'Quem foi o pai de Dom Afonso Henriques','Conde Dom Henrique','Afonso I','Henriques I','Conde João António');
insert into Perguntas values(4,1,'Quem foi a mãe de Dom Afonso Henriques?','Dona Teresa','Dona Joana','Dona Afonsina','Dona Maria');
insert into Perguntas values(5,1,'O nome de Dom Afonso Henriques foi dado em honra de quem?','Dom Afonso VI','Dom Henriques','Dom Sebastião','Dom Juan');
insert into Perguntas values(6,1,'Para que foi treinado Dom Afonso Henriques?','Para ser Cavaleiro','Para o campeonato de futebol','é uma ratoeira, ele não foi treinado','Para ser padre');
insert into Perguntas values(7,1,'Onde Dom Afonso Henriques se tornou cavaleiro?','Na catedral de Zamora','No castelo de Guimarães','Em São Maméde','Na Sé de Braga');
insert into Perguntas values(8,1,'Afonso VI, avô de DomAfonso Henriques, foi rei de?','Leão e Castela','Portugal','Espanha','França');
insert into Perguntas values(9,1,'Quem foi a esposa de Dom Henrique, pai de Dom Afonso Henriques?','Dona Teresa','Dona Fátima','Dona Rita','Dona Maria');
insert into Perguntas values(10,1,'Qual a relação familiar de Dom Afonso Henriques com Dom Henrique VI?','Neto','Filho','Amigalhaço','Pai');

-- Aula 2 - Batalha de S. Mamede
-- apresentação 4
insert into Apresentacoes values(4,2,'imagem',1,1);
insert into Multimedia values(9,4,2,1,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Txt1.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Img1.png');
insert into Multimedia values(10,4,2,2,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Txt2.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Img2.png');
insert into Multimedia values(11,4,2,3,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Txt3.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap1/Img3.png');
-- apresentação 5
insert into Apresentacoes values(5,2,'imagem',1,1);
insert into Multimedia values(12,5,2,1,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/img1.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/Img1.png');
insert into Multimedia values(13,5,2,2,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/img2.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/Img2.png');
--insert into Multimedia values(14,5,2,3,'Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/img3.txt','Assets/etapas/dafh/2 - Batalha de S. Mamede/Imagem/Ap2/Img3.png');
-- apresentação 6
insert into Apresentacoes values(6,2,'video',1,1);
insert into Multimedia values(15,6,2,1,NULL,'Assets/etapas/2 - Batalha de S. Mamede/Video/Ap1/Afonso2.webm');
-- ajudas aula 2
insert into Ajudas values(10,2,'O seu exército','Quem Dom Afonso reuniú para voltar ao condado portucalense?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/1-portucalense.wav');
insert into Ajudas values(11,2,'No ano 1128','Em que ano ocorreu a batalha de São Maméde?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/3-1128.wav');
insert into Ajudas values(12,2,'Para conquistar as suas legítimas terras','Porque marchou Dom Afonso Henriques para Guimarães','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/4-legitimas.wav');
insert into Ajudas values(13,2,'Dona Teresa','Quem defronta Dom Afonso na batalha de São Maméde?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/5-defronta.wav');
insert into Ajudas values(14,2,'O exército galego','Quem apoia Dona Teresa?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/6-apoiada.wav');
insert into Ajudas values(15,2,'Dom Afonso Henriques','Quem venceu a batalha de São Maméde?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/9-venceu.wav');
insert into Ajudas values(16,2,'Os mouros','Quem dominava as terras a sul?','Assets/etapas/dafh/2 - Batalha de S. Mamede/Ajudas/mouros.wav');
-- Perguntas aula 2
insert into Perguntas values(11,2,'O que Reuniú Dom Afonso para voltar ao condado Portucalense?','Um Exército','Um grupo de amigos','Os seus bens','A sua família');
insert into Perguntas values(12,2,'Para onde se dirigiu D. Afonso Henriques com o seu exército e o seu aio Égaz Moniz?','Guimarães','Castela','Espanha','Leão e Castela');
insert into Perguntas values(13,2,'Em que ano se deu a Batalha de S. Mamede?','1128','2009','1000','1500');
insert into Perguntas values(14,2,'Qual a intenção de D. Afonso Henriques quando marchou para Guimarães?','Conquistar as suas legitimas terras ','Discutir com a sua mãe','render-se à sua mãe','Defrontar os mouros');
insert into Perguntas values(15,2,'Quem defronta D. Afonso Henriques na Batalha de S. Mamede?','A sua mãe','O seu irmão','O seu pai','Os espanhóis');
insert into Perguntas values(16,2,'Após a Batalha de S. Mamede, D. Afonso Henriques ficou a governar...','O condado Portucalense','Espanha','O vitória de Guimarães','Portugal');
insert into Perguntas values(17,2,'Quem apoiou D. Teresa na Batalha de S. Mamede?','O exército galego','a polícia','O exército de Espanha','Ninguem apoiou Dona Teresa');
insert into Perguntas values(18,2,'Que batalha D. Afonso Henriques travou com a sua mãe?','Batalha de São Mamede','Batalha das Almofadas','Batalha difícil','Batalha do espaço');
insert into Perguntas values(19,2,'Quem venceu a Batalha de S. Mamede?','Dom Afonso Henriques','O rei de Portugal','ninguem venceu, fizeram as pazes','Os mouros');
insert into Perguntas values(20,2,'Qual a primeira grande vitória de D. Afonso Henriques?','Batalha de São Maméde','Batalha das Almofadas','Nunca teve uma vitória','A batalha de Aljubarota');
insert into Perguntas values(21,2,'Após a Batalha de S. Mamede, D. Afonso Henriques, partiu para o Sul. Quem dominava essas terras?','Os Mouros','Os Alentejanos','Os romanos','os franceses');


-- Aula 3 - 3 - Batalha de Ourique
-- apresentação 7
insert into Apresentacoes values(7,3,'imagem',1,1);
insert into Multimedia values(16,7,3,1,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG1.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG1.png');
insert into Multimedia values(17,7,3,2,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG2.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG2.png');
insert into Multimedia values(18,7,3,3,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG3.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG3.png');
insert into Multimedia values(19,7,3,4,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG4.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG4.png');
insert into Multimedia values(20,7,3,5,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG5.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap1/BatOuriqueIMG5.png');

--apresentação 8
insert into Apresentacoes values(8,3,'imagem',1,1);
insert into Multimedia values(21,8,3,1,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img1.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img1.png');
insert into Multimedia values(22,8,3,2,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img2.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img2.png');
insert into Multimedia values(23,8,3,3,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img3.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img3.png');
insert into Multimedia values(24,8,3,4,'Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img4.txt','Assets/etapas/dafh/3 - Batalha de Ourique/Imagem/Ap2/img4.png');
-- apresentação 9
insert into Apresentacoes values(9,3,'video',1,1);
insert into Multimedia values(25,9,3,1,NULL,'Assets/etapas/3 - Batalha de Ourique/Video/Ap1/Afonso3.webm');
-- ajudas aula 3
insert into Ajudas values(17,3,'1139','Em que ano aconteceu a batalha de Ourique?','Assets/etapas/dafh/3 - Batalha de Ourique/Ajudas/1-ourique.wav');
insert into Ajudas values(18,3,'Cinco reis mouros','Quem Dom Afonso defrontou na batalha de Ourique?','Assets/etapas/dafh/3 - Batalha de Ourique/Ajudas/2-mouros.wav');
insert into Ajudas values(19,3,'Depois da batalha de Ourique','Quando Afonso é eleito rei?','Assets/etapas/dafh/3 - Batalha de Ourique/Ajudas/3-eleito.wav');
insert into Ajudas values(20,3,'1146','Quando casou Dom Afonso','Assets/etapas/dafh/3 - Batalha de Ourique/Ajudas/5-casou.wav');
-- perguntas aula 3
insert into Perguntas values(22,3,'Em que ano foi a Batalha de Ourique?','1139','1109','1500','2000');
insert into Perguntas values(23,3,'Quantos eram os reis mouros que D. Afonso Henriques teve de enfrentar na batalha de Ourique?','5','12','6','3');
insert into Perguntas values(24,3,'Após a Batalha de Ourique, D. Afonso Henriques foi eleito...','Rei de Portugal','O cavaleiro do ano','Presidente da Câmara de Guimarães','Rei de Espanha');
insert into Perguntas values(25,3,'Por quem foi D. Afonso Henriques foi aclamado Rei de Portugal?','Pelas suas tropas','Pelo Rei de Leão e Castela','Por Dona Teresa','Pelo seu pai');
insert into Perguntas values(26,3,'Em que ano se casou D. Afonso Henriques?','1146','1974','1500','1149');
insert into Perguntas values(27,3,'Com quem casou D. Afonso Henriques?','Dona Mafalda','Dona Leonor','Dona Maria','Dona Joana');
insert into Perguntas values(28,3,'Quantos filhos teve D. Afonso Henriques?','7','5','3','é uma ratoeira, ele nunca teve filhos');
insert into Perguntas values(29,3,'De quem era o exercito que estava em menor número na batalha de Ourique?','Dom Afonso Henriques','Dona Teresa','Reis mouros','estavam equilibrados');
insert into Perguntas values(30,3,'De acordo com a lenda, quem abençoou D. Afonso Henriques, antes da batalha de Ourique?','Cristo','Um bruxo','O padre de Guimarães','ninguem');
insert into Perguntas values(31,3,'Em que momento D. Afonso Henriques foi declarado Rei de Portugal?','após a batalha de Ourique','quando casou','quando fez 15 anos','após a batalha de São Maméde');
insert into Perguntas values(32,3,'Em que cidade casou D. Afonso Henriques?','Coímbra','Braga','Lisboa','Guimarães');



-- aula 4 - Últimas Conquistas
-- apresentação 10
insert into Apresentacoes values(10,4,'imagem',1,1);
insert into Multimedia values(26,10,4,1,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Txt1.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Img1.png');
insert into Multimedia values(27,10,4,2,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Txt2.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Img2.png');
insert into Multimedia values(28,10,4,3,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Txt3.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Img3.png');
insert into Multimedia values(29,10,4,4,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Txt4.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Img4.png');
insert into Multimedia values(30,10,4,5,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Txt5.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap1/Img5.png');
-- apresentação 11
insert into Apresentacoes values(11,4,'imagem',1,1);
insert into Multimedia values(31,11,4,1,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img1.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img1.png');
insert into Multimedia values(32,11,4,2,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img2.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img2.png');
insert into Multimedia values(33,11,4,3,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img3.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img3.png');
insert into Multimedia values(34,11,4,4,'Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img4.txt','Assets/etapas/dafh/4 - Últimas Conquistas/Imagem/Ap2/img4.png');
-- apresentação 12
insert into Apresentacoes values(12,4,'video',1,1);
insert into Multimedia values(35,12,4,1,NULL,'Assets/etapas/4 - Últimas Conquistas/Video/Ap1/Afonso4.webm');

-- ajudas aula 4
insert into Ajudas values(21,4,'No ano de 1147','Quando parte Dom Afonso para Lisboa?','Assets/etapas/dafh/4 - Últimas Conquistas/Ajudas/1-lisboa.wav');
insert into Ajudas values(22,4,'O cerco a Lisboa Durou vários meses','Quanto tempo durou o cerco a Lisboa?','Assets/etapas/dafh/4 - Últimas Conquistas/Ajudas/3-cerco.wav');
insert into Ajudas values(23,4,'Os cruzados ingleses','Quem ajudou Dom Afonso em Lisboa?','Assets/etapas/dafh/4 - Últimas Conquistas/Ajudas/5-ingleses.wav');
insert into Ajudas values(24,4,'Aos mouros','A quem Dom Afonso conquistou Lisboa?','Assets/etapas/dafh/4 - Últimas Conquistas/Ajudas/6-mouros.wav');
insert into Ajudas values(25,4,'No ano de 1169','Quando se inicía a conquista de badajoz?','Assets/etapas/dafh/4 - Últimas Conquistas/Ajudas/7-badajoz.wav');
-- perguntas aula 4
insert into Perguntas values(33,4,'Em que ano D. Afonso Henriques parte para a conquistar Lisboa?','1147','1109','1974','2012');
insert into Perguntas values(34,4,'O que conquistou D. Afono Henriques em 1147?','Lisboa','Guimarães','Leão e Castela','Portugal');
insert into Perguntas values(35,4,'Durante quanto tem D. Afonso Henriques cercou Lisboa?','Durante Vários meses','alguns dias','Dois anos','Sete dias');
insert into Perguntas values(36,4,'Quem venceu a batalha de Ourique?','Dom Afonso Henriques','5 reis mouros','um rei mouro','Dona Teresa');
insert into Perguntas values(37,4,'Quem ajudou D. Afonso Henriques a conquistar Lisboa?','Templários ingleses','A legião romana','O capitão Salgueiro Maia','Dona Teresa');
insert into Perguntas values(38,4,'A quem é que D. Afonso Henriques conquistou a cidade de Lisboa?','Aos mouros','Aos templários ingleses','Aos espanhóis','Aos romanos');
insert into Perguntas values(39,4,'Em que ano se inicia a conquistas de Badajoz?','1169','1109','1974','2012');
insert into Perguntas values(40,4,'Quantos anos tinha D. Afonso Henriques quando tentou conquistar Badajoz?','60','50','29','69');
insert into Perguntas values(41,4,'O que aconteceu a D. Afonso Henriques durante a conquista de Badajoz?','Prtiu uma perna','Apanhou uma bebedeira','ficou enjoado','Foi aclamado rei de Portugal');
insert into Perguntas values(42,4,'A que se dedicou D. Afonso Henriques apÃ³s partir a perna?','A estruturar e fortalecer as terras conquistadas','À pesca','A novas conquistas','À música');


-- aula 5 - Reino de Portugal
-- apresentação 13
insert into Apresentacoes values(13,5,'imagem',1,1);
insert into Multimedia values(36,13,5,1,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Txt1.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Img1.png');
insert into Multimedia values(37,13,5,2,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Txt2.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Img2.png');
insert into Multimedia values(38,13,5,3,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Txt3.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Img3.png');
insert into Multimedia values(39,13,5,4,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Txt4.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap1/Img4.png');

-- apresentação 14
insert into Apresentacoes values(14,5,'imagem',1,1);
insert into Multimedia values(40,14,5,1,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img1.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img1.png');
insert into Multimedia values(41,14,5,2,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img2.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img2.png');
insert into Multimedia values(42,14,5,3,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img3.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img3.png');
insert into Multimedia values(43,14,5,4,'Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img4.txt','Assets/etapas/dafh/5 - Reino de Portugal/Imagem/Ap2/img4.png');

-- apresentação 15
insert into Apresentacoes values(15,5,'video',1,1);
insert into Multimedia values(44,15,5,1,NULL,'Assets/etapas/5 - Reino de Portugal/Video/Ap1/Afonso5.webm');

-- ajudas aula 5
insert into Ajudas values(26,5,'No ano de 1179.','Quando Dom Afonso Henriques é oficialmente reconhecido rei?','Assets/etapas/dafh/5 - Reino de Portugal/Ajudas/1-reconhecido.wav');
insert into Ajudas values(27,5,'Ao seu filho Dom Sancho.','A quem Dom Afonso passa parte dos seus poderes?','Assets/etapas/dafh/5 - Reino de Portugal/Ajudas/3-poderes.wav');
insert into Ajudas values(28,5,'Reinou durante 57 anos','Quanto tempo reinou Dom Afonso?','Assets/etapas/dafh/5 - Reino de Portugal/Ajudas/57anos.wav');
insert into Ajudas values(29,5,'No ano de 1185','Em que ano morreu Dom Afonso Henriques?','Assets/etapas/dafh/5 - Reino de Portugal/Ajudas/morreu.wav');
-- perguntas aula 5
insert into Perguntas values(43,5,'Em que ano é que D. Afonso Henriques foi  reconhecido como rei de Portugal?','1179','1109','1111','1254');
insert into Perguntas values(44,5,'Que Papa é que reconheceu D.Afonso Henriques como rei de Portugal?','Alexandre III','João II','Pedro V','Gervásio VII');
insert into Perguntas values(45,5,'Quando D. Afonso Henriques ficou mais velho, para quem é que passou parte dos seus poderes?','Para o seu Filho','Para o povo','Para Égaz Moniz','Para o seu Primo zé');
insert into Perguntas values(46,5,'Como se chama o filho de D. Afonso Henriques que ficou com a maior parte dos seus poderes?','Dom Sancho','Dom Pancho','Dom Tancho','Afonsinho');
insert into Perguntas values(47,5,'Qual o documento utilizado pelo papa para declarar oficialmente D. Afonso Henriques como rei?','bula','carta','Certidão de rei','Diploma de rei');
insert into Perguntas values(48,5,'Quem foi o primeiro rei de Portugal?','Dom Afonso Henriques','José Rei I','António Salazar','Luís de Camões');
insert into Perguntas values(49,5,'Dom Afonso Henriques é conhecido como...','O Conquistador','O Valentão','O Mauzão','O Destrutor');
insert into Perguntas values(50,5,'Quantos anos D. Afonso Henriques reinou Portugal?','57','25','32','Ele nunca foi rei de Portugal');
insert into Perguntas values(51,5,'Em que ano morreu D. Afonso Henriques?','1185','1200','1500','1254');



-- conteúdos audio
insert into Apresentacoes values(16,1,'audio',1,1);
insert into Multimedia values(45,16,1,1,'Assets/etapas/1 - Afonso Henriques/Audio/Ap1/mix1.txt','Assets/etapas/1 - Afonso Henriques/Audio/Ap1/mix1.wav');
insert into Apresentacoes values(17,2,'audio',1,1);
insert into Multimedia values(46,17,2,1,'Assets/etapas/2 - Batalha de S. Mamede/Audio/Ap1/mix2.txt','Assets/etapas/2 - Batalha de S. Mamede/Audio/Ap1/mix2.wav');
insert into Apresentacoes values(18,3,'audio',1,1);
insert into Multimedia values(47,18,3,1,'Assets/etapas/3 - Batalha de Ourique/Audio/Ap1/mix3.txt','Assets/etapas/3 - Batalha de Ourique/Audio/Ap1/mix3.wav');
insert into Apresentacoes values(19,4,'audio',1,1);
insert into Multimedia values(48,19,4,1,'Assets/etapas/4 - Últimas Conquistas/Audio/Ap1/mix4.txt','Assets/etapas/4 - Últimas Conquistas/Audio/Ap1/mix4.wav');
insert into Apresentacoes values(20,5,'audio',1,1);
insert into Multimedia values(49,20,5,1,'Assets/etapas/5 - Reino de Portugal/Audio/Ap1/mix5.txt','Assets/etapas/5 - Reino de Portugal/Audio/Ap1/mix5.wav');
/*
select * from aulas;
insert into Avaliacoes values('pedrinho',1,10,'video');
insert into Avaliacoes values('pedrinho',2,10,'video');
insert into Avaliacoes values('pedrinho',3,10,'video');
insert into Avaliacoes values('pedrinho',4,10,'audio');

insert into Avaliacoes values('carlitos',1,10,'video');
insert into Avaliacoes values('carlitos',2,10,'imagem');

select * from Avaliacoes;

insert into Conquistas values('pedrinho','D. Afonso Henriques');
*/