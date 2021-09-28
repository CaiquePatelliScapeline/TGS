DROP DATABASE DB_TGS;
/* Criar o banco de dados */
CREATE DATABASE DB_TGS;

/* Usar o banco correto */
USE DB_TGS;

/* Criar tabela de procedimentos */
CREATE TABLE TB_PROCEDURES (
	ID_PROCEDURE INT PRIMARY KEY IDENTITY NOT NULL,
	PROCEDURE_TITLE VARCHAR(20)
);

/* Criar tabela de pacientes */
CREATE TABLE TB_PATIENTS (
	CPF_PATIENT VARCHAR(14) PRIMARY KEY NOT NULL,
	RG_PATIENT VARCHAR(12) UNIQUE NOT NULL,
	NAME_PATIENT VARCHAR(20),
	LAST_NAME VARCHAR(40),
	NICKNAME VARCHAR(20),
	BIRTH_DATE DATE,
	HEIGHT DECIMAL(18,2),
	WEIGHT_PATIENT DECIMAL(18,2),
	EMAIL VARCHAR(40),
	TELEPHONE VARCHAR(13),
	CELLPHONE VARCHAR(14),
	STREET VARCHAR(50),
	NEIGHBORHOOD VARCHAR(20),
	CITY VARCHAR(30),
	DISTRICT VARCHAR(20),
	CEP VARCHAR(10),
	COMPLEMENT VARCHAR(15),
	NUMBER INT
);

/* Criar a tabela de dentistas */
CREATE TABLE TB_DENTISTA (
	CRO_DENTIST VARCHAR(6) PRIMARY KEY NOT NULL,
	NAME_DENTIST VARCHAR(20),
	LAST_NAME VARCHAR(40),
	EXPERTISE VARCHAR(15)
);

CREATE TABLE TB_EMPLOYEES (
	CPF_EMPLOYEE VARCHAR(14) PRIMARY KEY NOT NULL,
	NAME_EMPLOYEE VARCHAR(20),
	LAST_NAME VARCHAR(40),
	EMAIL VARCHAR(40),
	TELEPHONE VARCHAR(13),
	CELLPHONE VARCHAR(14),
	PASSWORD_EMPLOYEE VARCHAR(255)
);

CREATE TABLE TB_CONSULTS(
	ID_CONSULT INT PRIMARY KEY IDENTITY NOT NULL,
	CPF_PATIENT VARCHAR(14),
	CRO_DENTIST VARCHAR(6),
	DATE_CONSULT DATE,
	TIME_CONSULT TIME,
	ID_PROCEDURE INT

	CONSTRAINT FK_PATIENT
	FOREIGN KEY (CPF_PATIENT)
	REFERENCES TB_PATIENTS (CPF_PATIENT),

	CONSTRAINT FK_DENTIST
	FOREIGN KEY (CRO_DENTIST)
	REFERENCES TB_DENTISTA (CRO_DENTIST),

	CONSTRAINT FK_PROCEDURE
	FOREIGN KEY (ID_PROCEDURE)
	REFERENCES TB_PROCEDURES (ID_PROCEDURE),
);

CREATE TABLE TB_SCHEDULING (
	ID_SCHEDULE INT PRIMARY KEY IDENTITY NOT NULL,
	CRO_DENTIST VARCHAR(6),
	DATE_SCHEDULE DATE,
	TIME_SCHEDULE TIME,
	STATUS_SCHEDULE BIT,
	ID_CONSULT INT,
	CPF_EMPLOYEE VARCHAR(14)

	CONSTRAINT  FK_DENTISTA
	FOREIGN KEY (CRO_DENTIST)
	REFERENCES  TB_DENTISTA (CRO_DENTIST),

	CONSTRAINT FK_CONSULT
	FOREIGN KEY (ID_CONSULT)
	REFERENCES TB_CONSULTS (ID_CONSULT),

	CONSTRAINT FK_EMPLOYEE
	FOREIGN KEY (CPF_EMPLOYEE)
	REFERENCES TB_EMPLOYEES (CPF_EMPLOYEE),
);

INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('AVALIACAO');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CONSULTA');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CIRURGIA');
INSERT INTO TB_PROCEDURES (PROCEDURE_TITLE) VALUES ('CANAL');

INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('803.047.456-75', 'MIRIAM', 'ZEQUINI', 'MIRIAMZEQUINI@YAHOO.COM', '(19)3875-0023', '(19)93546-7512', 'WELCOME123');
INSERT INTO TB_EMPLOYEES (CPF_EMPLOYEE, NAME_EMPLOYEE, LAST_NAME, EMAIL, TELEPHONE, CELLPHONE, PASSWORD_EMPLOYEE) VALUES ('485.654.458-48', 'MURILO', 'SCHALI', 'MURILO123@GMAIL.COM', '', '(19)97252-3013', '1234');

INSERT INTO TB_DENTISTA (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('10.154', 'FERNANDO', 'NAKAMURA', 'CIRURGIAO');
INSERT INTO TB_DENTISTA (CRO_DENTIST, NAME_DENTIST, LAST_NAME, EXPERTISE) VALUES ('20.300', 'LETICIA', 'SABATELA', 'CANAL');

INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('123.456.789-10', '88.758.333-1', 'GIANLUCA', 'MICHELI', 'COMILAO', '12/06/1950', 1.78, 75.5, 'GIANLUCA@GMAIL.COM', '(19)1234-5698', '(19)91234-5698', 'RUA DAS FLORES', 'ITAICI', 'INDAIATUBA', 'SP', '13.330-000', '', 10);
INSERT INTO TB_PATIENTS (CPF_PATIENT, RG_PATIENT, NAME_PATIENT, LAST_NAME, NICKNAME, BIRTH_DATE, HEIGHT, WEIGHT_PATIENT, EMAIL, TELEPHONE, CELLPHONE, STREET, NEIGHBORHOOD, CITY, DISTRICT, CEP, COMPLEMENT, NUMBER) VALUES ('123.456.789-11', '88.758.333-2', 'CAIQUE', 'PATELLI', '', '08/04/2003', 1.72, 75.5, 'CAIQUE@GMAIL.COM', '(19)4434-5698', '(19)94434-5698', 'RUA BRASIL', 'SANTA ELISA', 'ITUPEVA', 'SP', '13.330-000', '', 1547);

INSERT INTO TB_SCHEDULING (CRO_DENTIST, DATE_SCHEDULE, TIME_SCHEDULE, STATUS_SCHEDULE) VALUES ('10.154', '2021-09-21', '08:00:00.0000', 0);

INSERT INTO TB_CONSULTS (CPF_PATIENT, CRO_DENTIST, DATE_CONSULT, TIME_CONSULT, ID_PROCEDURE) VALUES ('123.456.789-10', '10.154', '2021-09-21', '08:00:00.0000', 1);

UPDATE TB_SCHEDULING SET STATUS_SCHEDULE = 1, ID_CONSULT = 1,CPF_EMPLOYEE = '803.047.456-75' WHERE DATE_SCHEDULE = '2021-09-21' AND TIME_SCHEDULE = '08:00:00.0000';

SELECT * FROM TB_SCHEDULING;