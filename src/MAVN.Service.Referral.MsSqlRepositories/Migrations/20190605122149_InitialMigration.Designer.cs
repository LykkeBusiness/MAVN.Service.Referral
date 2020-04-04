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
    [Migration("20190605122149_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("referral")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ReferralCode")
                        .HasColumnName("referral_code")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("ReferralCode")
                        .IsUnique()
                        .HasFilter("[referral_code] IS NOT NULL");

                    b.ToTable("customer_referral");
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
