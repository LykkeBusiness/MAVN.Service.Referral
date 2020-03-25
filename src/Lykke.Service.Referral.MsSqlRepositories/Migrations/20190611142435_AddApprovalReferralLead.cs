﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lykke.Service.Referral.MsSqlRepositories.Migrations
{
    public partial class AddApprovalReferralLead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "approved_referral_lead",
                schema: "referral",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    refer_lead_id = table.Column<Guid>(nullable: false),
                    salesforce_id = table.Column<string>(type: "varchar(200)", nullable: true),
                    timestamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_approved_referral_lead", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "approved_referral_lead",
                schema: "referral");
        }
    }
}