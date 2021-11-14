-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Dec 08. 16:11
-- Kiszolgáló verziója: 10.4.14-MariaDB
-- PHP verzió: 7.2.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `kiseloadas`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `deleted_user`
--

CREATE TABLE `deleted_user` (
  `ID` int(11) NOT NULL,
  `Descripton` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `deleted_user`
--

INSERT INTO `deleted_user` (`ID`, `Descripton`) VALUES
(1, 'Törölt'),
(2, 'Nem törölt');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `transfer`
--

CREATE TABLE `transfer` (
  `ID` int(11) NOT NULL,
  `ID_sender` int(11) DEFAULT NULL,
  `ID_receiver` int(11) DEFAULT NULL,
  `payment` int(11) DEFAULT NULL,
  `time_stamp` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `transfer`
--

INSERT INTO `transfer` (`ID`, `ID_sender`, `ID_receiver`, `payment`, `time_stamp`) VALUES
(1, 1, 2, 2000, '2020-12-06 09:08:43'),
(2, 1, 2, 2000, '2020-12-15 10:10:39'),
(3, 3, 2, 2000, '2020-12-17 10:12:08'),
(4, 2, 1, 2000, '2020-12-06 09:08:43');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `balance` int(11) DEFAULT NULL,
  `ID_Deleted_User` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`ID`, `name`, `Email`, `password`, `balance`, `ID_Deleted_User`) VALUES
(1, 'Fá Zoltán', 'fa.zoltan@gmail.com', '12345', 5000, 2),
(2, 'vég béla', 'veg.bela@gmail.com', '12345', -2000, 2),
(3, 'Riz Ottó', 'riz.otto@gmail.com', '12345', 2000, 2),
(4, 'Feles Elek', 'Feles.Elek@gmail.com', '12345', 5000, 2);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `deleted_user`
--
ALTER TABLE `deleted_user`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `transfer`
--
ALTER TABLE `transfer`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_sender` (`ID_sender`),
  ADD KEY `ID_receiver` (`ID_receiver`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_Deleted_User` (`ID_Deleted_User`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `deleted_user`
--
ALTER TABLE `deleted_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `transfer`
--
ALTER TABLE `transfer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `transfer`
--
ALTER TABLE `transfer`
  ADD CONSTRAINT `transfer_ibfk_1` FOREIGN KEY (`ID_sender`) REFERENCES `users` (`ID`),
  ADD CONSTRAINT `transfer_ibfk_2` FOREIGN KEY (`ID_receiver`) REFERENCES `users` (`ID`);

--
-- Megkötések a táblához `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`ID_Deleted_User`) REFERENCES `deleted_user` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
