-- ============================================
-- DATABASE SETUP untuk Klinik Apotek App
-- ============================================

-- Create database
CREATE DATABASE IF NOT EXISTS klinik_db;
USE klinik_db;

-- Table: pasien
CREATE TABLE IF NOT EXISTS pasien (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    umur INT DEFAULT 0,
    alamat TEXT,
    nohp VARCHAR(20),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table: obat
CREATE TABLE IF NOT EXISTS obat (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100) NOT NULL,
    stok INT DEFAULT 0,
    harga DECIMAL(10,2) DEFAULT 0,
    deskripsi TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table: users
CREATE TABLE IF NOT EXISTS users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    role ENUM('Admin', 'Apoteker', 'User') NOT NULL,
    pasien_id INT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (pasien_id) REFERENCES pasien(id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table: resep
CREATE TABLE IF NOT EXISTS resep (
    id INT AUTO_INCREMENT PRIMARY KEY,
    pasien_id INT NOT NULL,
    obat_id INT NOT NULL,
    dosis VARCHAR(50),
    aturan TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (pasien_id) REFERENCES pasien(id) ON DELETE CASCADE,
    FOREIGN KEY (obat_id) REFERENCES obat(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table: transaksi
CREATE TABLE IF NOT EXISTS transaksi (
    id INT AUTO_INCREMENT PRIMARY KEY,
    pasien_id INT NOT NULL,
    obat_id INT NOT NULL,
    jumlah INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    tanggal DATETIME DEFAULT CURRENT_TIMESTAMP,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (pasien_id) REFERENCES pasien(id) ON DELETE CASCADE,
    FOREIGN KEY (obat_id) REFERENCES obat(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insert default admin user
INSERT INTO users (username, password, role, pasien_id) VALUES
('admin', 'admin123', 'Admin', NULL),
('apoteker', 'apoteker123', 'Apoteker', NULL)
ON DUPLICATE KEY UPDATE username=username;

-- Insert sample obat
INSERT INTO obat (nama, stok, harga, deskripsi) VALUES
('Paracetamol 500mg', 100, 5000, 'Obat penurun panas dan pereda nyeri'),
('Amoxicillin 500mg', 50, 15000, 'Antibiotik untuk infeksi bakteri'),
('Vitamin C 1000mg', 200, 8000, 'Suplemen vitamin C untuk daya tahan tubuh'),
('OBH Combi', 75, 12000, 'Obat batuk berdahak'),
('Antasida', 60, 7000, 'Obat maag dan gangguan pencernaan')
ON DUPLICATE KEY UPDATE nama=nama;

-- View untuk riwayat transaksi lengkap
CREATE OR REPLACE VIEW v_transaksi_lengkap AS
SELECT 
    t.id,
    t.tanggal,
    p.nama AS nama_pasien,
    p.nohp,
    o.nama AS nama_obat,
    t.jumlah,
    o.harga AS harga_satuan,
    t.total,
    u.username
FROM transaksi t
LEFT JOIN pasien p ON t.pasien_id = p.id
LEFT JOIN obat o ON t.obat_id = o.id
LEFT JOIN users u ON u.pasien_id = p.id
ORDER BY t.tanggal DESC;
