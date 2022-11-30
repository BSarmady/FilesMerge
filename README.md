# FilesMerge
This is a small utility to merge files in folders recursively

<p align="center">
<img src="images/dalgenerator.png" width="320">
</p>

Sometimes I needed to merge files from multiple directories, but choose the order of files to my liking before merging them.
As an example, I needed to create a single SQL script file to create database from multiple files in multiple folders of a SQL Server project, but considering the order of which files should run (Tables first, then triggers, and also dependencies before referencing scripts)

I created this simple tool to allow get list of files in folders recursively then modify order of them and then merge them into a single output file.

