﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public class Messages
    {
        public static string CarAdded = "Araba başarıyla eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarInvalid = "Araba yoktur";
        public static string DailyPriceInvalid = "Günlük fiyat tutarı geçersiz";
        public static string CarDeleted = "Araba başarıyla silindi";
        public static string CarUpdated = "Araba başarıyla silindi";
        public static string CarListed = "Arabalar listelendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandAdded = "Marka başarıyla eklendi";
        public static string BrandDeleted = "Marka başarıyla silindi";
        public static string BrandUpdated = "Marka başarıyla güncellendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorAdded = "Renk başarıyla eklendi";
        public static string ColorDeleted = "Renk başarıyla silindi";
        public static string ColorUpdated = "Renk başarıyla güncellendi";
        public static string UserNameInvalid = "Kullanıcı ismi ve soyismi geçersiz";
        public static string UserAdded = "Kullanıcı başarıyla eklendi";
        public static string CustomerAdded = "Müşteri başarıyla eklendi";
        public static string RentalAdded = "Kiralama kaydı başarıyla eklendi";
        public static string InvalidRental = " Kiralanacak araba müsait değil"; 
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
        public static object MaintenanceTime { get; internal set; }
    }
}
