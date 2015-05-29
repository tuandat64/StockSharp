namespace StockSharp.Algo.Derivatives
{
	using System;

	using StockSharp.BusinessEntities;

	/// <summary>
	/// ��������� ������ ������� �������� "������" �� ������� �����-������.
	/// </summary>
	public interface IBlackScholes
	{
		/// <summary>
		/// ������.
		/// </summary>
		Security Option { get; }

		/// <summary>
		/// ����������� ���������� ������.
		/// </summary>
		decimal RiskFree { get; set; }

		/// <summary>
		/// ������ ��������� �� ������.
		/// </summary>
		decimal Dividend { get; set; }

		/// <summary>
		/// ���������� ������ �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>������ �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Premium(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� ������ �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>������ �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Delta(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� ����� �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>����� �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Gamma(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� ���� �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>���� �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Vega(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� ���� �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>���� �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Theta(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� �� �������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="deviation">����������� ����������.</param>
		/// <param name="assetPrice">���� �������� ������.</param>
		/// <returns>�� �������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? Rho(DateTimeOffset currentTime, decimal? deviation = null, decimal? assetPrice = null);

		/// <summary>
		/// ���������� ��������������� �������������.
		/// </summary>
		/// <param name="currentTime">������� �����.</param>
		/// <param name="premium">������ �� �������.</param>
		/// <returns>��������������� �������������. ���� �������� ����� <see langword="null"/>, �� ������ �������� � ������ ������ ����������.</returns>
		decimal? ImpliedVolatility(DateTimeOffset currentTime, decimal premium);
	}
}