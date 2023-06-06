-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 06 juin 2023 à 12:24
-- Version du serveur : 8.0.27
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--
CREATE DATABASE IF NOT EXISTS `mediatek` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `mediatek`;

-- --------------------------------------------------------

--
-- Création de l'utilisateur : 'utilisateur'
--
CREATE USER 'utilisateur'@'localhost' IDENTIFIED BY 'motdepasse';
GRANT ALL PRIVILEGES ON `mediatek`.* TO 'utilisateur'@'localhost';

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` date NOT NULL,
  `idmotif` int NOT NULL,
  `datefin` date DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `idmotif`, `datefin`) VALUES
(11, '2023-06-02', 3, '2023-06-04'),
(13, '2023-06-04', 2, '2023-06-09'),
(2, '2023-06-03', 3, '2023-06-14'),
(9, '2023-06-04', 2, '2023-06-10'),
(3, '2023-06-02', 2, '2023-06-13'),
(12, '2023-06-04', 3, '2023-06-08'),
(12, '2023-06-07', 3, '2023-06-13'),
(6, '2023-06-06', 1, '2023-06-12'),
(1, '2023-06-03', 3, '2023-06-09'),
(5, '2023-06-02', 2, '2023-06-12'),
(4, '2023-06-02', 3, '2023-06-14'),
(3, '2023-06-03', 3, '2023-06-15'),
(5, '2023-06-03', 3, '2023-06-14'),
(11, '2023-06-07', 3, '2023-06-13'),
(7, '2023-06-06', 3, '2023-06-13'),
(7, '2023-06-05', 4, '2023-06-10'),
(13, '2023-06-05', 1, '2023-06-09'),
(2, '2023-06-02', 2, '2023-06-11'),
(3, '2023-06-05', 2, '2023-06-13'),
(6, '2023-06-07', 2, '2023-06-12'),
(5, '2023-06-04', 2, '2023-06-11'),
(10, '2023-06-05', 3, '2023-06-08'),
(9, '2023-06-03', 2, '2023-06-14'),
(4, '2023-06-04', 3, '2023-06-15'),
(15, '2023-06-03', 2, '2023-06-14'),
(8, '2023-06-05', 0, '2023-06-12'),
(6, '2023-06-04', 3, '2023-06-13'),
(6, '2023-06-05', 3, '2023-06-11'),
(11, '2023-06-06', 4, '2023-06-12'),
(5, '2023-06-06', 3, '2023-06-12'),
(2, '2023-06-05', 3, '2023-06-11'),
(13, '2023-06-01', 2, '2023-06-09'),
(2, '2023-06-13', 3, '2023-06-14'),
(9, '2023-06-09', 2, '2023-06-10'),
(3, '2023-06-11', 2, '2023-06-13'),
(12, '2023-06-06', 3, '2023-06-08'),
(12, '2023-06-12', 3, '2023-06-13'),
(6, '2023-06-11', 1, '2023-06-12'),
(1, '2023-06-08', 3, '2023-06-09'),
(5, '2023-06-11', 2, '2023-06-12'),
(4, '2023-06-13', 3, '2023-06-14'),
(3, '2023-06-14', 3, '2023-06-15'),
(5, '2023-06-13', 3, '2023-06-21'),
(11, '2023-06-11', 3, '2023-06-12'),
(7, '2023-06-12', 3, '2023-06-13'),
(11, '2023-07-01', 1, '2023-07-09'),
(2, '2023-06-12', 1, '2023-06-14'),
(3, '2023-06-01', 2, '2023-06-09'),
(10, '2023-06-11', 2, '2023-06-13'),
(13, '2023-06-02', 2, '2023-06-09'),
(13, '2023-06-06', 2, '2023-06-09'),
(2, '2023-06-09', 3, '2023-06-14'),
(13, '2023-06-21', 0, '2023-06-27'),
(3, '2023-06-06', 2, '2023-06-09'),
(10, '2023-06-04', 2, '2023-06-13'),
(11, '2023-06-03', 4, '2023-06-15'),
(10, '2023-06-07', 3, '2023-06-09'),
(12, '2023-06-03', 3, '2023-06-14'),
(8, '2023-06-07', 2, '2023-06-08'),
(4, '2023-06-05', 4, '2023-06-11'),
(2, '2023-06-04', 1, '2023-06-13'),
(1, '2023-06-06', 3, '2023-06-12'),
(10, '2023-06-03', 2, '2023-06-12'),
(2, '2023-06-06', 3, '2023-06-12'),
(11, '2023-06-05', 4, '2023-06-06'),
(13, '2023-06-03', 4, '2023-06-25'),
(18, '2023-06-05', 3, '2023-06-15');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE `motif` (
  `idmotif` int NOT NULL,
  `libelle` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif_familial'),
(4, 'conge_parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `idpersonnel` int NOT NULL,
  `idservice` int NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `idservice`, `nom`, `prenom`, `tel`, `mail`) VALUES
(1, 1, 'Donaldson', 'Aimee', '03 98 22 26 37', 'erat.nonummy.ultricies@yahoo.com'),
(2, 1, 'Knight', 'Kennan', '07 25 38 03 26', 'amet.consectetuer@aol.couk'),
(4, 1, 'Miranda', 'Channing', '02 44 16 17 02', 'proin.vel@protonmail.couk'),
(5, 1, 'Lang', 'Ariana', '02 86 26 58 95', 'sodales.nisi.magna@icloud.com'),
(6, 2, 'Washington', 'Grace', '06 96 41 52 15', 'ultricies@outlook.org'),
(7, 2, 'Hogan', 'Jescie', '03 87 16 68 01', 'euismod.mauris.eu@outlook.couk'),
(8, 2, 'Gutierrez', 'Kiona', '03 50 17 70 48', 'suspendisse.sed@hotmail.couk'),
(9, 2, 'Solis', 'Gray', '07 37 94 71 21', 'venenatis.a@icloud.com'),
(10, 2, 'Mcclure', 'Bryar', '01 27 74 70 21', 'sodales.purus.in@icloud.net'),
(11, 3, 'Craft', 'Avram', '07 15 10 68 36', 'dictum.eu@google.ca'),
(13, 3, 'Hays', 'Darius', '02 47 79 59 16', 'interdum@google.com'),
(14, 3, 'Jacobson', 'Isaac', '04 50 32 31 42', 'nisi.sem@icloud.couk'),
(15, 3, 'Joseph', 'Ferris', '01 32 76 60 98', 'montes.nascetur.ridiculus@aol.org');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', '967520ae23e8ee14888bae72809031b98398ae4a636773e18fff917d77679334');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE `service` (
  `idservice` int NOT NULL,
  `nom` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'mediation_culturelle'),
(3, 'pret');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `i_fk_absence_motif1` (`idmotif`),
  ADD KEY `i_fk_absence_personnel1` (`idpersonnel`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `i_fk_personnel_service1` (`idservice`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `idmotif` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `idservice` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
