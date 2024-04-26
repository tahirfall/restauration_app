-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  jeu. 24 août 2023 à 10:07
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `restaurant`
--

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

DROP TABLE IF EXISTS `commandes`;
CREATE TABLE IF NOT EXISTS `commandes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IntitulesProduits` varchar(255) NOT NULL,
  `Quantite` int(11) NOT NULL,
  `PrixTotal` double NOT NULL,
  `Etat` varchar(50) NOT NULL,
  `DateCommande` varchar(10) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `commandes`
--

INSERT INTO `commandes` (`ID`, `IntitulesProduits`, `Quantite`, `PrixTotal`, `Etat`, `DateCommande`) VALUES
(1, 'Jus Bissap,  Riz au poisson,  ', 4, 4000, 'PAYE', '28/9/2022'),
(2, 'Pizza,  Jus Bouye,  Jus Bissap,  ', 4, 13000, 'PAYE', '26/7/2023'),
(8, 'Crépe,  Salade,  ', 11, 16500, 'PAYE', '24/8/2023'),
(9, 'Jus Bouye,  Jus Bissap,  ', 5, 5000, 'PAYE', '24/8/2023');

-- --------------------------------------------------------

--
-- Structure de la table `produits`
--

DROP TABLE IF EXISTS `produits`;
CREATE TABLE IF NOT EXISTS `produits` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `intitule` varchar(50) NOT NULL,
  `prix` double NOT NULL,
  `quantite` int(11) NOT NULL,
  `description` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `produits`
--

INSERT INTO `produits` (`id`, `intitule`, `prix`, `quantite`, `description`) VALUES
(1, 'Pizza', 5500, 9, 'Pizza Complet'),
(2, 'Crépe', 1500, 9, 'Crépe Sucré'),
(3, 'Jus Bouye', 1000, 10, 'Jus Bouye Bouteille d\'1 L'),
(5, 'Yassa Poulet', 2000, 4, 'Plat de Yassa Poulet'),
(6, 'Salade', 1500, 6, 'Plat de salade pour dessert'),
(7, 'Jus Bissap', 1000, 10, 'Bouteille d\'1L de jus de bissap'),
(10, 'Riz au poisson', 1000, 9, 'Plat de riz au poisson'),
(11, 'Glace Vanille', 2000, 12, 'Pot de glace vanille');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `role` varchar(50) NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `login` (`login`)
) ENGINE=MyISAM AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `nom`, `prenom`, `role`, `login`, `password`) VALUES
(13, 'chef', 'chef', 'CHEF', 'chef', 'passer123'),
(14, 'restaur', 'restaur', 'RESTAURATEUR', 'rest', 'passer123'),
(24, 'chef1', 'chef1', 'CHEF', 'chef1', 'passer123'),
(8, 'Fall', 'Tahir', 'ADMINISTRATEUR', 'tahir', 'passer123');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
