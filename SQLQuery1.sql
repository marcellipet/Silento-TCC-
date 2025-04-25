create table Dsp_Dispositivo (
	Id uniqueidentifier not null default newid(),
	IpShield varchar(20) null,
	StatusDisp bit not null,
	Decibeis varchar(255) not null,
	LimiteDecibeis varchar(255)

	constraint PK_Dispositivo primary key(Id)
)

create table End_Endereco (
	Id bigint identity not null,
	CEP varchar(15) not null,
	Cidade varchar(100) not null,
	Estado char(2) not null,
	Bairro varchar(150) not null,
	Logradouro varchar(255) not null,
	IsActive bit not null,
	IdDispositivo uniqueidentifier constraint FK_Endereco_Dispositivo references Dsp_Dispositivo(Id)

	constraint PK_Endereco primary key(Id)
)

create table Atv_AtivacaoEstado(
	Id int not null,
	Nome varchar(80) not null,
	Descricao varchar(180) not null,

	constraint Pk_AtivacaoEstado primary key(Id)
)

create table Dsp_DispositivoAtivacao (
	Id bigint identity not null,
	HoraInicio datetime not null,
	HoraFim datetime null,
	HoraLimite datetime not null,
	IdDispositivo uniqueidentifier references Dsp_Dispositivo(Id),
	IdEstado int constraint FK_DispositivoAtivacao_AtivacaoEstado references Atv_AtivacaoEstado(Id)
	--PK_Endereco bigint foreign key references End_Endereco(Id)

	constraint PK_DispositivoAtivacao primary key(Id)
)


insert into Atv_AtivacaoEstado(Id, Nome, Descricao)
	values('1', 'Monitorando', 'O dispositivo está
ativado pois o limite de decibéis foi
ultrapassado.');

insert into Atv_AtivacaoEstado(Id, Nome, Descricao)
	values('2', 'Desativado', 'O dispositivo foi
desativado pois os ruídos diminuíram.');

insert into Atv_AtivacaoEstado(Id, Nome, Descricao)
	values('3', ' PotencialViolacao', 'O dispositivo
ultrapassou o tempo limite estabelecido
para altos ruidos.');


--alter table Dsp_DispositivoAtivacao
--add IdEstado int constraint FK_DispositivoAtivacao_AtivacaoEstado references Atv_AtivacaoEstado(Id)