Create Procedure SP_FillSecintificNameComboBox
AS
  Select sn.Sn_ID ,sn.Sn_Name From TblSecintificName Sn
Return 