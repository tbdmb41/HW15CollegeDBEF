﻿namespace CollegeDBEF.Migrations
{
using System;
using System.Data.Entity.Migrations;

public partial class AddInstructor : DbMigration
 {
public override void Up()
 {
 AddColumn("dbo.Classes", "Instructor", c => c.String());
 }
public override void Down()
 {
 DropColumn("dbo.Classes", "Instructor");
 }
    }
}