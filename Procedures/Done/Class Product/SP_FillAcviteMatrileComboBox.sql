Create Procedure SP_FillAcviteMatrileComboBox
AS
  Select am.Am_ID ,Am.Am_Name From TblAcviteMatrile Am
Return 