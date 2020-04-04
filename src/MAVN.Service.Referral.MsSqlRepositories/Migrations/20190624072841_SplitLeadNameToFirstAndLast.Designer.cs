// <auto-generated />
using System;
using MAVN.Service.Referral.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.Referral.MsSqlRepositories.Migrations
{
    [DbContext(typeof(ReferralContext))]
    [Migration("20190624072841_SplitLeadNameToFirstAndLast")]
    partial class SplitLeadNameToFirstAndLast
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("referral")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.ApprovedReferralLeadEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("ReferralLeadId")
                        .HasColumnName("refer_lead_id");

                    b.Property<string>("SalesforceId")
                        .HasColumnName("salesforce_id")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("approved_referral_lead");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.FriendReferralHistoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("ReferredId")
                        .HasColumnName("referred_id");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id");

                    b.HasKey("Id");

                    b.HasIndex("ReferredId");

                    b.HasIndex("ReferrerId");

                    b.ToTable("friend_referral");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.PropertyPurchaseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("ReferralLeadId")
                        .HasColumnName("refer_lead_id");

                    b.Property<string>("SalesforceId")
                        .HasColumnName("salesforce_id")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnName("timestamp");

                    b.HasKey("Id");

                    b.ToTable("property_purchase");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.PurchaseReferralHistoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("ReferredId")
                        .HasColumnName("referred_id");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id");

                    b.HasKey("Id");

                    b.HasIndex("ReferredId");

                    b.HasIndex("ReferrerId");

                    b.ToTable("purchase_referral");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralEntity", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<string>("ReferralCode")
                        .HasColumnName("referral_code")
                        .HasColumnType("varchar(64)");

                    b.HasKey("CustomerId");

                    b.HasIndex("ReferralCode")
                        .IsUnique()
                        .HasFilter("[referral_code] IS NOT NULL");

                    b.ToTable("customer_referral");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralLeadEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("AgentId")
                        .HasColumnName("agent_id");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnName("creation_datetime");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ResponseStatus")
                        .HasColumnName("response_status")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("SalesforceAgentId")
                        .HasColumnName("salesforce_agent_id")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("SalesforceId")
                        .HasColumnName("salesforce_id")
                        .HasColumnType("varchar(200)");

                    b.Property<int>("State")
                        .HasColumnName("state");

                    b.HasKey("Id");

                    b.ToTable("referral_lead");
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.FriendReferralHistoryEntity", b =>
                {
                    b.HasOne("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralEntity", "Referred")
                        .WithMany("FriendsReferred")
                        .HasForeignKey("ReferredId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralEntity", "Referrer")
                        .WithMany("FriendReferrers")
                        .HasForeignKey("ReferrerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MAVN.Service.Referral.MsSqlRepositories.Entities.PurchaseReferralHistoryEntity", b =>
                {
                    b.HasOne("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralEntity", "Referred")
                        .WithMany("PurchasesReferred")
                        .HasForeignKey("ReferredId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MAVN.Service.Referral.MsSqlRepositories.Entities.ReferralEntity", "Referrer")
                        .WithMany("PurchaseReferrers")
                        .HasForeignKey("ReferrerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
