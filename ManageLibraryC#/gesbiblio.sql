-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Client: localhost
-- Généré le: Lun 12 Août 2013 à 19:49
-- Version du serveur: 5.5.24-log
-- Version de PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données: `gesbiblio`
--

-- --------------------------------------------------------

--
-- Structure de la table `auteur`
--

CREATE TABLE IF NOT EXISTS `auteur` (
  `nomaut` varchar(100) NOT NULL,
  `prenaut` varchar(100) NOT NULL,
  `telaut` varchar(100) NOT NULL,
  `adraut` varchar(15) NOT NULL,
  PRIMARY KEY (`nomaut`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `editeur`
--

CREATE TABLE IF NOT EXISTS `editeur` (
  `codedit` varchar(100) NOT NULL,
  `nomedit` varchar(100) NOT NULL,
  `prenedit` varchar(20) NOT NULL,
  `teledit` int(11) NOT NULL,
  `adredit` varchar(20) NOT NULL,
  PRIMARY KEY (`codedit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `emprunt`
--

CREATE TABLE IF NOT EXISTS `emprunt` (
  `numempr` varchar(10) NOT NULL,
  `datempr` datetime NOT NULL,
  `numlect` varchar(10) NOT NULL,
  PRIMARY KEY (`numempr`),
  KEY `numlect` (`numlect`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `exemplaire`
--

CREATE TABLE IF NOT EXISTS `exemplaire` (
  `numexpl` varchar(100) NOT NULL,
  `codeli` varchar(10) NOT NULL,
  PRIMARY KEY (`numexpl`),
  KEY `codeli` (`codeli`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `lecteur`
--

CREATE TABLE IF NOT EXISTS `lecteur` (
  `numlect` varchar(100) NOT NULL,
  `nomlect` varchar(100) NOT NULL,
  `prenlect` varchar(100) NOT NULL,
  `telect` varchar(100) NOT NULL,
  `adrlect` varchar(20) NOT NULL,
  PRIMARY KEY (`numlect`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `ligneemprunt`
--

CREATE TABLE IF NOT EXISTS `ligneemprunt` (
  `numexpl` varchar(10) NOT NULL,
  `numempr` varchar(10) NOT NULL,
  `duree` int(11) NOT NULL,
  `dateretour` datetime NOT NULL,
  PRIMARY KEY (`numexpl`,`numempr`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `lignelivre`
--

CREATE TABLE IF NOT EXISTS `lignelivre` (
  `codeli` varchar(10) NOT NULL,
  `nomaut` varchar(10) NOT NULL,
  PRIMARY KEY (`codeli`,`nomaut`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `livre`
--

CREATE TABLE IF NOT EXISTS `livre` (
  `codeli` varchar(100) NOT NULL,
  `nomli` varchar(100) NOT NULL,
  `dataparition` date NOT NULL,
  `codthem` varchar(10) NOT NULL,
  `codedit` varchar(10) NOT NULL,
  PRIMARY KEY (`codeli`),
  KEY `codthem` (`codthem`,`codedit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `theme`
--

CREATE TABLE IF NOT EXISTS `theme` (
  `codthem` varchar(100) NOT NULL,
  `libthem` varchar(100) NOT NULL,
  PRIMARY KEY (`codthem`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
