CREATE DATABASE `point_of_sale`;
use `point_of_sale`;
CREATE TABLE `dailysales` (
  `ID` int(11) NOT NULL,
  `employeeID` varchar(10) NOT NULL,
  `totalSales` decimal(11,2) NOT NULL,
  `date` varchar(10) NOT NULL,
  `datePrepared` varchar(20) NOT NULL,
  `isClosed` varchar(5) NOT NULL DEFAULT 'No'
);

CREATE TABLE `employee` (
  `ID` int(11) NOT NULL,
  `employeeID` varchar(10) NOT NULL,
  `name` varchar(35) NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `address` varchar(50) NOT NULL,
  `position` varchar(8) NOT NULL,
  `block` varchar(3) NOT NULL
);

INSERT INTO `employee` (`ID`, `employeeID`, `name`, `Phone`, `address`, `position`, `block`) VALUES
(0, 'guest', 'ANEK IT CONSULT', '0554013980', 'nketiaernest18@gmail.com', 'Guest', 'NO');

CREATE TABLE `login` (
  `ID` int(11) NOT NULL,
  `employeeID` varchar(10) NOT NULL,
  `password` varchar(50) NOT NULL,
  `position` varchar(20) NOT NULL,
  `block` varchar(3) NOT NULL
);

INSERT INTO `login` (`ID`, `employeeID`, `password`, `position`, `block`) VALUES
(0, 'guest', 'guest', 'guest', 'NO');

CREATE TABLE `product` (
  `ID` int(11) NOT NULL,
  `Product_ID` varchar(11) NOT NULL,
  `Pro_Name` varchar(50) NOT NULL,
  `type` varchar(10) NOT NULL,
  `instock` int(11) NOT NULL,
  `Price` decimal(11,2) NOT NULL,
  `date` varchar(20) NOT NULL,
  `catID` varchar(10) NOT NULL,
  `selling_price` decimal(11,2) NOT NULL,
  `hide` varchar(3) NOT NULL,
  `Average_Quantity` int(11) NOT NULL
);

CREATE TABLE `producttype` (
  `ID` int(11) NOT NULL,
  `catID` varchar(10) NOT NULL,
  `category` varchar(50) NOT NULL
);

CREATE TABLE `sales` (
  `ID` int(11) NOT NULL,
  `item` varchar(50) NOT NULL,
  `Qty` int(11) NOT NULL,
  `price` decimal(11,2) NOT NULL,
  `amount` decimal(11,2) NOT NULL,
  `trackRec` varchar(5) NOT NULL,
  `employeeID` varchar(10) NOT NULL,
  `date` varchar(25) NOT NULL,
  `month` varchar(10) NOT NULL,
  `profit` decimal(11,2) NOT NULL,
  `Gen_Mount` varchar(2) NOT NULL
);

ALTER TABLE `dailysales`
  ADD PRIMARY KEY (`ID`);


ALTER TABLE `employee`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `employeeID` (`employeeID`);


ALTER TABLE `login`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `employeeID` (`employeeID`);

ALTER TABLE `product`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Product_ID` (`Product_ID`);

ALTER TABLE `producttype`
  ADD PRIMARY KEY (`ID`);


ALTER TABLE `sales`
  ADD PRIMARY KEY (`ID`);

  ALTER TABLE `dailysales`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;


ALTER TABLE `employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `login`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `product`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;


ALTER TABLE `producttype`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

ALTER TABLE `sales`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;