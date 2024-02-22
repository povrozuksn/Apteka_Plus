-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Фев 22 2024 г., 19:13
-- Версия сервера: 5.5.25
-- Версия PHP: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `apteka`
--

-- --------------------------------------------------------

--
-- Структура таблицы `defaultdisign`
--

CREATE TABLE IF NOT EXISTS `defaultdisign` (
  `type` varchar(200) NOT NULL,
  `parametr` varchar(100) NOT NULL,
  `value` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `defaultdisign`
--

INSERT INTO `defaultdisign` (`type`, `parametr`, `value`) VALUES
('System.Windows.Forms.Label', 'FONT', 'Comic Sans MS;14,25'),
('System.Windows.Forms.Label', 'FONT_COLOR', '-65536'),
('System.Windows.Forms.TextBox', 'FONT', 'Times New Roman;14,25'),
('System.Windows.Forms.TextBox', 'FORECOLOR', '-8388480'),
('System.Windows.Forms.TextBox', 'BACKCOLOR', '-6817285'),
('System.Windows.Forms.Button', 'FONT', 'Cambria;14,25'),
('System.Windows.Forms.Button', 'FORECOLOR', '-16776961'),
('System.Windows.Forms.Button', 'BACKCOLOR', '-25089'),
('System.Windows.Forms.Panel', 'PANEL_COLOR', '-90');

-- --------------------------------------------------------

--
-- Структура таблицы `level1`
--

CREATE TABLE IF NOT EXISTS `level1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `adress` varchar(200) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Дамп данных таблицы `level1`
--

INSERT INTO `level1` (`id`, `name`, `adress`, `pic`) VALUES
(1, 'Аптека №1', '', 'Аптека1.jpg'),
(2, 'Аптека №2', '', 'Аптека2.jpg'),
(3, 'Аптека №3', '', 'Аптека3.jpg'),
(4, 'Аптека №4', '', 'Аптека4.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `level2`
--

CREATE TABLE IF NOT EXISTS `level2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `id_apteka` int(11) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=19 ;

--
-- Дамп данных таблицы `level2`
--

INSERT INTO `level2` (`id`, `name`, `id_apteka`, `pic`) VALUES
(1, 'Психотропные медикаменты', 1, '1.jpg'),
(2, 'Препараты местноанестезирующего действия', 1, '2.jpg'),
(3, 'Моче-желчегонные препараты', 1, '3.jpg'),
(4, 'Средства для терапии секреторики', 1, '4.jpg'),
(5, 'Антибиотики антисептики', 1, '5.jpg'),
(6, 'Психотропные медикаменты', 2, '1.jpg'),
(7, 'Препараты местноанестезирующего действия', 2, '2.jpg'),
(8, 'Моче-желчегонные препараты', 2, '3.jpg'),
(10, 'Антибиотики антисептики', 2, '5.jpg'),
(11, 'Психотропные медикаменты', 3, '1.jpg'),
(12, 'Препараты местноанестезирующего действия', 3, '2.jpg'),
(13, 'Моче-желчегонные препараты', 3, '3.jpg'),
(14, 'Средства для терапии секреторики', 3, '4.jpg'),
(15, 'Антибиотики антисептики', 3, '5.jpg'),
(16, 'Препараты местноанестезирующего действия', 4, '2.jpg'),
(17, 'Средства для терапии секреторики', 4, '4.jpg'),
(18, 'Антибиотики антисептики', 4, '5.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `level3`
--

CREATE TABLE IF NOT EXISTS `level3` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `id_apteka` int(11) NOT NULL,
  `id_class` int(11) NOT NULL,
  `pic` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=25 ;

--
-- Дамп данных таблицы `level3`
--

INSERT INTO `level3` (`id`, `name`, `id_apteka`, `id_class`, `pic`) VALUES
(1, 'Андростанолон', 1, 1, 'Andractim.jpg'),
(2, 'Левомицетин', 2, 10, 'Левомицетин.jpg'),
(3, 'Сорбитол', 1, 3, 'Сорбитол.jpg'),
(4, 'Сорбитол', 2, 8, 'Сорбитол.jpg'),
(5, 'Аллилпродин', 1, 1, ''),
(6, 'Гидрокодон', 1, 1, ''),
(7, 'Беноксин', 1, 2, ''),
(8, 'Левобупивакаин', 1, 2, ''),
(9, 'Оксибупрокаин', 1, 2, ''),
(10, 'Аллохол', 1, 3, ''),
(11, 'Холензим', 1, 3, ''),
(12, 'Аскориксол', 1, 4, ''),
(13, 'Метабронх', 1, 4, ''),
(14, 'Цефиксим', 1, 5, ''),
(15, 'Безитрамид', 2, 6, ''),
(16, 'Диампромид', 2, 6, ''),
(17, 'Анестезин', 2, 7, ''),
(18, 'Динексан', 2, 7, ''),
(19, 'Холосас', 2, 8, ''),
(20, 'Цефиксим', 2, 10, ''),
(21, 'Сумамед', 2, 10, ''),
(22, 'Зиннат', 2, 10, ''),
(23, 'Азитромицин', 2, 10, ''),
(24, 'Флемоксин', 2, 10, '');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `familiya` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `admin` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `familiya`, `login`, `pass`, `admin`) VALUES
(1, 'Сергей', 'Поврозюк', 'povser', '123', 1),
(2, 'Вася', 'Петров', 'vas', '123', 0),
(3, 'Петя', 'Васин', 'petr', '123', 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
