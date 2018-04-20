-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 20 Avril 2018 à 17:55
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `ppe_prod`
--

-- --------------------------------------------------------

--
-- Structure de la table `employe`
--

CREATE TABLE IF NOT EXISTS `employe` (
  `IDEmploye` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(255) NOT NULL,
  `Prenom` varchar(255) NOT NULL,
  `Pseudo` varchar(255) NOT NULL,
  `MotDePasse` varchar(255) NOT NULL,
  `TypeDeConnexion` tinyint(1) NOT NULL DEFAULT '0',
  `NumTel` varchar(255) NOT NULL,
  PRIMARY KEY (`IDEmploye`)
) ENGINE=MyISAM  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `employe`
--

INSERT INTO `employe` (`IDEmploye`, `Nom`, `Prenom`, `Pseudo`, `MotDePasse`, `TypeDeConnexion`, `NumTel`) VALUES
(1, 'Victor', 'Morel', 'vic', 'fou', 0, '06 38 10 64 99'),
(2, 'Cousin', 'Cecile', 'cecile', 'cousin', 0, '01 78 52 10 63'),
(3, 'test', 'test', 'admin', 'admin', 1, '');

-- --------------------------------------------------------

--
-- Structure de la table `fiche`
--

CREATE TABLE IF NOT EXISTS `fiche` (
  `IDEmploye` int(11) NOT NULL,
  `IDFiche` int(11) NOT NULL AUTO_INCREMENT,
  `DateMMYYYY` varchar(255) NOT NULL DEFAULT '0',
  `Actif` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IDEmploye`,`IDFiche`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `fiche`
--

INSERT INTO `fiche` (`IDEmploye`, `IDFiche`, `DateMMYYYY`, `Actif`) VALUES
(1, 1, '12.2017', 0),
(1, 2, '01.2018', 0),
(1, 3, '02.2018', 2),
(1, 5, '04.2018', 1),
(1, 4, '03.2018', 0),
(2, 1, '03.2018', 1);

-- --------------------------------------------------------

--
-- Structure de la table `forfait`
--

CREATE TABLE IF NOT EXISTS `forfait` (
  `IDEmploye` int(11) NOT NULL,
  `IDForfait` int(11) NOT NULL AUTO_INCREMENT,
  `IDFiche` int(11) NOT NULL DEFAULT '0',
  `Repas` varchar(255) NOT NULL,
  `Etape` varchar(255) NOT NULL,
  `Distance` varchar(255) NOT NULL,
  `Datee` varchar(255) NOT NULL,
  `Duree` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`IDEmploye`,`IDForfait`),
  KEY `IDFiche` (`IDFiche`),
  KEY `IDFiche_2` (`IDFiche`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `forfait`
--

INSERT INTO `forfait` (`IDEmploye`, `IDForfait`, `IDFiche`, `Repas`, `Etape`, `Distance`, `Datee`, `Duree`) VALUES
(1, 1, 4, '1', '10', '12', '16/03/2018', 1),
(1, 2, 4, '2', '2', '100', '18/03/2018', 1),
(1, 3, 4, '1', '2', '4', '09/03/2018', 1),
(2, 1, 1, '3', '2', '20', '08/03/2018', 1),
(1, 4, 3, '2', '4', '10', '02/02/2018', 1),
(1, 5, 4, '2', '5', '30', '10/03/2018', 1),
(1, 6, 4, '2', '2', '10', '10/03/2018', 1);

-- --------------------------------------------------------

--
-- Structure de la table `horsforfait`
--

CREATE TABLE IF NOT EXISTS `horsforfait` (
  `IDEmploye` int(11) NOT NULL,
  `IDHorsForfait` int(11) NOT NULL AUTO_INCREMENT,
  `IDFiche` int(11) NOT NULL DEFAULT '0',
  `Image` varchar(255) NOT NULL,
  `Description` varchar(255) NOT NULL,
  `Montant` int(11) NOT NULL,
  `Datee` varchar(255) NOT NULL,
  `Status` tinyint(1) NOT NULL,
  PRIMARY KEY (`IDEmploye`,`IDHorsForfait`),
  KEY `IDFiche` (`IDFiche`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contenu de la table `horsforfait`
--

INSERT INTO `horsforfait` (`IDEmploye`, `IDHorsForfait`, `IDFiche`, `Image`, `Description`, `Montant`, `Datee`, `Status`) VALUES
(1, 1, 4, 'avatar.png', 'Test', 90, '09/03/2018', 1);

-- --------------------------------------------------------

--
-- Structure de la table `stats_employe`
--

CREATE TABLE IF NOT EXISTS `stats_employe` (
  `IDEmploye` int(11) NOT NULL AUTO_INCREMENT,
  `Error` int(11) NOT NULL,
  `Succes` int(11) NOT NULL,
  PRIMARY KEY (`IDEmploye`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `stats_employe`
--

INSERT INTO `stats_employe` (`IDEmploye`, `Error`, `Succes`) VALUES
(1, 3, 36),
(2, 1, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
