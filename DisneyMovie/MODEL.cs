using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using ScottPlot;

// 1. Questa classe deve riflettere ESATTAMENTE le colonne del CSV
public class DisneyMovieData
{
    [LoadColumn(0)] public string Title;
    [LoadColumn(1)] public string DataString; // "21/12/1937"
    [LoadColumn(2)] public string Genre;
    [LoadColumn(3)] public string Rating;
    [LoadColumn(4)] public float TotalGross;
    [LoadColumn(5), ColumnName("Label")] public float Banana; // Inflation Adjusted Gross
}

// 2. Questa classe serve per i dati già puliti (con l'anno come numero)
public class MovieYearData
{
    public string Genre { get; set; }
    public string MPAARating { get; set; }
    public float InflationAdjustedGross { get; set; } // Il Target
    public float Year { get; set; }
}

public class DisneyMoviePrediction
{
    [ColumnName("Score")] public float PredictedBanana { get; set; }
}