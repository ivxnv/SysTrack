using MySql.Data.MySqlClient;
using SysTrack.Models;
using System;
using System.Collections.Generic;

public class DatabaseService
{
    private readonly string _connectionString;

    public DatabaseService(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Create (Insert) Operation
    public bool InsertComputer(Computer computer)
    {
        if (!computer.IsValid()) return false;

        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                const string query = @"
INSERT INTO computers(ProductName, RamSize, CpuFrequency, DeliveryDate, CustomerName, IsFinanced, PurchasePrice, MonthlyRate, FinancingTerm, FinalPrice, MacAddress)
VALUES(@ProductName, @RamSize, @CpuFrequency, @DeliveryDate, @CustomerName, @IsFinanced, @PurchasePrice, @MonthlyRate, @FinancingTerm, @FinalPrice, @MacAddress)";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", computer.ProductName);
                command.Parameters.AddWithValue("@RamSize", computer.RamSize);
                command.Parameters.AddWithValue("@CpuFrequency", computer.CpuFrequency);
                command.Parameters.AddWithValue("@DeliveryDate", computer.DeliveryDate);
                command.Parameters.AddWithValue("@CustomerName", computer.CustomerName);
                command.Parameters.AddWithValue("@IsFinanced", computer.IsFinanced);
                command.Parameters.AddWithValue("@PurchasePrice", computer.PurchasePrice);
                command.Parameters.AddWithValue("@MonthlyRate", computer.MonthlyRate);
                command.Parameters.AddWithValue("@FinancingTerm", computer.FinancingTerm);
                command.Parameters.AddWithValue("@FinalPrice", computer.FinalPrice);
                command.Parameters.AddWithValue("@MacAddress", computer.MacAddress);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Hier könnten Sie den Fehler loggen oder weitergeben
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            return false;
        }
        return true;
    }

    // Read (Select) Operation
    public List<Computer> GetAllComputers()
    {
        var computers = new List<Computer>();

        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                const string query = "SELECT * FROM computers";

            var command = new MySqlCommand(query, connection);
            connection.Open();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var computer = new Computer
                    {
                        Id = reader.GetInt32("Id"),
                        ProductName = reader.GetString("ProductName"),
                        RamSize = reader.GetInt32("RamSize"),
                        CpuFrequency = reader.GetDouble("CpuFrequency"),
                        DeliveryDate = reader.GetDateTime("DeliveryDate"),
                        CustomerName = reader.GetString("CustomerName"),
                        IsFinanced = reader.GetBoolean("IsFinanced"),
                        PurchasePrice = reader.GetDecimal("PurchasePrice"),
                        MonthlyRate = reader.GetDecimal("MonthlyRate"),
                        FinancingTerm = reader.GetInt32("FinancingTerm"),
                        FinalPrice = reader.GetDecimal("FinalPrice"),
                        MacAddress = reader.GetString("MacAddress")
                    };

                    computers.Add(computer);
                }
            }
            }
        }
        catch (Exception ex)
        {
            // Hier könnten Sie den Fehler loggen oder weitergeben
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
        }

        return computers;
    }

    // Update Operation
    public bool UpdateComputer(Computer computer)
    {
        if (!computer.IsValid()) return false;

        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                const string query = @"
UPDATE computers
SET ProductName = @ProductName,
    RamSize = @RamSize,
    CpuFrequency = @CpuFrequency,
    DeliveryDate = @DeliveryDate,
    CustomerName = @CustomerName,
    IsFinanced = @IsFinanced,
    PurchasePrice = @PurchasePrice,
    MonthlyRate = @MonthlyRate,
    FinancingTerm = @FinancingTerm,
    FinalPrice = @FinalPrice,
    MacAddress = @MacAddress
WHERE Id = @Id";

            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", computer.Id);
            command.Parameters.AddWithValue("@ProductName", computer.ProductName);
            command.Parameters.AddWithValue("@RamSize", computer.RamSize);
            command.Parameters.AddWithValue("@CpuFrequency", computer.CpuFrequency);
            command.Parameters.AddWithValue("@DeliveryDate", computer.DeliveryDate);
            command.Parameters.AddWithValue("@CustomerName", computer.CustomerName);
            command.Parameters.AddWithValue("@IsFinanced", computer.IsFinanced);
            command.Parameters.AddWithValue("@PurchasePrice", computer.PurchasePrice);
            command.Parameters.AddWithValue("@MonthlyRate", computer.MonthlyRate);
            command.Parameters.AddWithValue("@FinancingTerm", computer.FinancingTerm);
            command.Parameters.AddWithValue("@FinalPrice", computer.FinalPrice);
            command.Parameters.AddWithValue("@MacAddress", computer.MacAddress);

            connection.Open();
            command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Hier könnten Sie den Fehler loggen oder weitergeben
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            return false;
        }
        return true;
    }

    // Delete Operation
    public bool DeleteComputer(int computerId)
    {
        try
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                const string query = "DELETE FROM computers WHERE Id = @Id";

            var command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", computerId);

            connection.Open();
            command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Hier könnten Sie den Fehler loggen oder weitergeben
            Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
            return false;
        }
        return true;
    }
}
