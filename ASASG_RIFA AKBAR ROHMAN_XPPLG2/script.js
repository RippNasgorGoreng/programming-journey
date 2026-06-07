
// ===== MANAJEMEN PENGGUNA (USERS) =====

/**
 * Mengambil daftar pengguna dari localStorage.
 * Jika belum ada, inisialisasi dengan akun demo default.
 * @returns {Array} Array of user objects {username, password}
 */
function getUsers() {
    const users = localStorage.getItem('edutask_users');
    if (!users) {
        // Buat akun default jika belum pernah ada user sama sekali
        const defaultUsers = [{ username: 'siswa', password: 'siswa123' }];
        localStorage.setItem('edutask_users', JSON.stringify(defaultUsers));
        return defaultUsers;
    }
    return JSON.parse(users);
}

/**
 * Menyimpan array pengguna ke localStorage.
 * @param {Array} users - Array of user objects
 */
function saveUsers(users) {
    localStorage.setItem('edutask_users', JSON.stringify(users));
}

/**
 * Menangani proses Login.
 * Memverifikasi username dan password.
 * @param {Event} event - Event submit form
 */
function handleLogin(event) {
    event.preventDefault();
    const username = document.getElementById('loginUser').value.trim();
    const password = document.getElementById('loginPass').value.trim();

    const users = getUsers();
    const user = users.find(u => u.username === username && u.password === password);

    if (user) {
        // Set status login dan simpan username aktif
        localStorage.setItem('edutask_loggedIn', 'true');
        localStorage.setItem('edutask_user', username);
        
        // Buat data tugas default jika belum ada
        if (!localStorage.getItem('edutask_tasks')) {
            initDefaultTasks();
        }
        window.location.href = 'dashboard.html';
    } else {
        showToast('Username atau password salah!', 'error');
    }
}

/**
 * Menangani proses Registrasi (Daftar).
 * Memeriksa apakah username sudah dipakai dan konfirmasi password.
 * @param {Event} event - Event submit form
 */
function handleRegister(event) {
    event.preventDefault();
    const username = document.getElementById('regUser').value.trim();
    const password = document.getElementById('regPass').value.trim();
    const password2 = document.getElementById('regPass2').value.trim();

    if (password !== password2) {
        showToast('Konfirmasi password tidak cocok!', 'error');
        return;
    }

    const users = getUsers();
    const userExists = users.some(u => u.username === username);

    if (userExists) {
        showToast('Username sudah digunakan, pilih yang lain!', 'error');
        return;
    }

    // Tambahkan user baru dan simpan
    users.push({ username: username, password: password });
    saveUsers(users);

    showToast('Registrasi berhasil! Silakan login.', 'success');
    
    // Pindah ke tab login secara otomatis
    switchTab('login');
    document.getElementById('loginUser').value = username;
}


// ===== DATA TUGAS DEFAULT =====

/**
 * Menghasilkan array tugas bawaan dengan tanggal dinamis relatif terhadap hari ini.
 * @returns {Array} Array of task objects
 */
function getDefaultTasks() {
    const today = new Date();
    // Helper untuk membuat deadline relatif (misal: d(2) = 2 hari lagi)
    const d = (offset) => {
        const date = new Date(today);
        date.setDate(date.getDate() + offset);
        return date.toISOString().split('T')[0];
    };

    return [
        { id: 1, judul: "Membuat Makalah Energi Terbarukan", mapel: "IPA", deadline: d(2), prioritas: "Tinggi", status: "Belum Selesai", deskripsi: "Membuat makalah tentang energi terbarukan minimal 5 halaman lengkap dengan daftar pustaka" },
        { id: 2, judul: "Tugas Praktik Jaringan Komputer", mapel: "TKJ", deadline: d(-1), prioritas: "Tinggi", status: "Belum Selesai", deskripsi: "Konfigurasi router dan switch menggunakan Cisco Packet Tracer" },
        { id: 3, judul: "Presentasi Bahasa Indonesia", mapel: "B. Indonesia", deadline: d(-3), prioritas: "Sedang", status: "Selesai", deskripsi: "Presentasi tentang cerita pendek pilihan secara berkelompok" },
        { id: 4, judul: "Laporan Praktikum Fisika", mapel: "Fisika", deadline: d(4), prioritas: "Tinggi", status: "Belum Selesai", deskripsi: "Laporan praktikum gerak parabola lengkap dengan analisis data dan grafik" },
        { id: 5, judul: "Mengerjakan Soal Matematika", mapel: "Matematika", deadline: d(-2), prioritas: "Sedang", status: "Selesai", deskripsi: "Menyelesaikan soal latihan halaman 125-130 tentang persamaan kuadrat" },
        { id: 6, judul: "Desain Poster Digital", mapel: "Desain Grafis", deadline: d(1), prioritas: "Rendah", status: "Belum Selesai", deskripsi: "Desain poster bertema lingkungan menggunakan Adobe Illustrator" },
        { id: 7, judul: "Membaca Novel Sastra", mapel: "B. Inggris", deadline: d(5), prioritas: "Rendah", status: "Selesai", deskripsi: "Membaca dan membuat ringkasan novel To Kill a Mockingbird" },
        { id: 8, judul: "Proyek Pemrograman Web", mapel: "Pemrograman", deadline: d(0), prioritas: "Tinggi", status: "Belum Selesai", deskripsi: "Membuat website sederhana menggunakan HTML, CSS, dan JavaScript" }
    ];
}

/**
 * Inisialisasi data tugas default ke localStorage.
 * Dipanggil saat user login untuk pertama kali.
 */
function initDefaultTasks() {
    localStorage.setItem('edutask_tasks', JSON.stringify(getDefaultTasks()));
}

// ===== CRUD TUGAS (localStorage) =====

/**
 * Mengambil daftar tugas dari localStorage.
 * Jika tidak ada, buat data default baru.
 * @returns {Array} Array of task objects
 */
function getTasks() {
    const data = localStorage.getItem('edutask_tasks');
    if (!data) {
        initDefaultTasks();
        return getDefaultTasks();
    }
    return JSON.parse(data);
}

/**
 * Menyimpan array tugas ke localStorage.
 * @param {Array} tasks - Array of task objects
 */
function saveTasks(tasks) {
    localStorage.setItem('edutask_tasks', JSON.stringify(tasks));
}


// ===== AUTENTIKASI & SIDEBAR =====

/**
 * Memaksa pengguna untuk login.
 * Jika tidak ada sesi login, redirect ke halaman login.
 */
function requireAuth() {
    if (localStorage.getItem('edutask_loggedIn') !== 'true') {
        window.location.href = 'login.html';
    }
}

/**
 * Menghapus sesi login dan redirect ke halaman login.
 */
function logout() {
    localStorage.removeItem('edutask_loggedIn');
    localStorage.removeItem('edutask_user');
    window.location.href = 'login.html';
}

/**
 * Merender sidebar navigasi secara dinamis.
 * Menentukan menu mana yang aktif dan apakah game terkunci/terbuka.
 * @param {string} activePage - Nama halaman saat ini (misal: 'dashboard', 'tugas')
 */
function renderSidebar(activePage) {
    const tasks = getTasks();
    // Cek apakah semua tugas sudah selesai untuk membuka kunci game
    const allDone = tasks.length > 0 && tasks.every(t => t.status === 'Selesai');

    const sidebar = document.getElementById('sidebar');
    sidebar.innerHTML = `
        <div class="sidebar-header">
            <div class="sidebar-logo">
                <div class="sidebar-logo-icon"><i class="fas fa-graduation-cap"></i></div>
                <div><span>EduTask</span><small>Manajemen Tugas</small></div>
            </div>
        </div>
        <nav class="sidebar-nav">
            <a href="dashboard.html" class="nav-link ${activePage === 'dashboard' ? 'active' : ''}">
                <i class="fas fa-home"></i><span>Dashboard</span>
            </a>
            <a href="tugas.html" class="nav-link ${activePage === 'tugas' ? 'active' : ''}">
                <i class="fas fa-list-check"></i><span>Daftar Tugas</span>
            </a>
            <a href="tambah.html" class="nav-link ${activePage === 'tambah' ? 'active' : ''}">
                <i class="fas fa-plus-circle"></i><span>Tambah Tugas</span>
            </a>
            <a href="statistik.html" class="nav-link ${activePage === 'statistik' ? 'active' : ''}">
                <i class="fas fa-chart-bar"></i><span>Statistik</span>
            </a>
            <a href="game.html" class="nav-link ${activePage === 'game' ? 'active' : ''} ${allDone ? 'game-unlocked' : ''}" id="navGame">
                <i class="fas fa-gamepad"></i><span>Game</span>
                ${allDone 
                    ? '<i class="fas fa-unlock unlock-icon" style="color:#22C55E; margin-left:auto;"></i>' 
                    : '<i class="fas fa-lock lock-icon"></i>'}
            </a>
            <a href="tentang.html" class="nav-link ${activePage === 'tentang' ? 'active' : ''}">
                <i class="fas fa-info-circle"></i><span>Tentang</span>
            </a>
        </nav>
        <div class="sidebar-footer">
            <a href="#" class="nav-link" onclick="logout(); return false;">
                <i class="fas fa-sign-out-alt"></i><span>Keluar</span>
            </a>
        </div>
    `;
}

/**
 * Memperbarui status ikon kunci game secara langsung tanpa reload halaman.
 */
function updateGameLock() {
    const tasks = getTasks();
    const allDone = tasks.length > 0 && tasks.every(t => t.status === 'Selesai');
    const navGame = document.getElementById('navGame');
    if (navGame && allDone) {
        navGame.classList.add('game-unlocked');
        const lockIcon = navGame.querySelector('.lock-icon');
        if (lockIcon) lockIcon.remove();
        if (!navGame.querySelector('.unlock-icon')) {
            const unlock = document.createElement('i');
            unlock.className = 'fas fa-unlock unlock-icon';
            unlock.style.cssText = 'color:#22C55E; margin-left:auto;';
            navGame.appendChild(unlock);
        }
    }
}

// ===== UTILITIES =====

/**
 * Toggle tampilan sidebar pada layar mobile.
 */
function toggleSidebar() {
    document.getElementById('sidebar').classList.toggle('open');
    document.querySelector('.sidebar-overlay').classList.toggle('show');
}

/**
 * Mengubah format tanggal string (YYYY-MM-DD) menjadi format lebih mudah dibaca.
 * Menambahkan keterangan relatif seperti "Hari ini" atau "2 hari lagi".
 * @param {string} dateStr - Tanggal format YYYY-MM-DD
 * @returns {string} Tanggal yang sudah diformat
 */
function formatDate(dateStr) {
    const months = ['Januari', 'Februari', 'Maret', 'April', 'Mei', 'Juni', 'Juli', 'Agustus', 'September', 'Oktober', 'November', 'Desember'];
    const d = new Date(dateStr + 'T00:00:00');
    const today = new Date();
    today.setHours(0, 0, 0, 0);
    const diff = Math.ceil((d - today) / (1000 * 60 * 60 * 24));

    let relative = '';
    if (diff === 0) relative = ' (Hari ini)';
    else if (diff === 1) relative = ' (Besok)';
    else if (diff === -1) relative = ' (Kemarin)';
    else if (diff < -1) relative = ` (${Math.abs(diff)} hari lalu)`;
    else if (diff > 1) relative = ` (${diff} hari lagi)`;

    return `${d.getDate()} ${months[d.getMonth()]} ${d.getFullYear()}${relative}`;
}

/**
 * Animasi sederhana untuk menghitung angka dari 0 ke target.
 * @param {string} elementId - ID elemen DOM yang akan diubah textnya
 * @param {number} target - Angka target akhir
 */
function animateCounter(elementId, target) {
    const el = document.getElementById(elementId);
    if (!el) return;
    let current = 0;
    const step = Math.max(1, Math.floor(target / 20)); // Hitung kenaikan per langkah
    const interval = setInterval(() => {
        current += step;
        if (current >= target) {
            current = target;
            clearInterval(interval);
        }
        el.textContent = current;
    }, 40);
}

/**
 * Menampilkan notifikasi toast di pojok kanan atas.
 * @param {string} message - Pesan yang ditampilkan
 * @param {string} type - Tipe toast ('success', 'error', 'info')
 */
function showToast(message, type = 'info') {
    const container = document.getElementById('toastContainer');
    if (!container) return;
    const toast = document.createElement('div');
    toast.className = `toast toast-${type}`;

    let icon = 'fa-info-circle';
    if (type === 'success') icon = 'fa-check-circle';
    if (type === 'error') icon = 'fa-exclamation-circle';

    toast.innerHTML = `<i class="fas ${icon}"></i> ${message}`;
    container.appendChild(toast);

    // Hapus toast setelah 3 detik
    setTimeout(() => { toast.remove(); }, 3000);
}
// ===== DARK MODE =====

/**
 * Menginisialisasi tema (Terang/Gelap) saat halaman dimuat.
 * Mengambil preferensi dari localStorage agar pengaturan tidak hilang saat pindah halaman.
 */
function initTheme() {
    const savedTheme = localStorage.getItem('edutask_theme');
    if (savedTheme === 'dark') {
        document.documentElement.classList.add('dark-mode');
    } else {
        document.documentElement.classList.remove('dark-mode');
    }
}

/**
 * Mengganti antara mode terang dan mode gelap.
 * Menyimpan pilihan ke localStorage dan mengubah ikon pada tombol.
 */
function toggleDarkMode() {
    const html = document.documentElement;
    html.classList.toggle('dark-mode');
    
    if (html.classList.contains('dark-mode')) {
        localStorage.setItem('edutask_theme', 'dark');
    } else {
        localStorage.setItem('edutask_theme', 'light');
    }
    
    // Update ikon di sidebar secara langsung
    updateThemeIcon();
}

/**
 * Memperbarui ikon matahari/bulan pada tombol Dark Mode di sidebar.
 */
function updateThemeIcon() {
    const icon = document.getElementById('themeIcon');
    const text = document.getElementById('themeText');
    if (icon && text) {
        if (document.documentElement.classList.contains('dark-mode')) {
            icon.className = 'fas fa-sun';
            text.textContent = 'Mode Terang';
        } else {
            icon.className = 'fas fa-moon';
            text.textContent = 'Mode Gelap';
        }
    }
}

// Panggil initTheme saat script dimuat agar tidak ada "flash" warna putih
initTheme();


/**
 * Merender sidebar navigasi secara dinamis.
 * Menentukan menu mana yang aktif dan apakah game terkunci/terbuka.
 * @param {string} activePage - Nama halaman saat ini (misal: 'dashboard', 'tugas')
 */
function renderSidebar(activePage) {
    const tasks = getTasks();
    const allDone = tasks.length > 0 && tasks.every(t => t.status === 'Selesai');

    const sidebar = document.getElementById('sidebar');
    sidebar.innerHTML = `
        <div class="sidebar-header">
            <div class="sidebar-logo">
                <div class="sidebar-logo-icon"><i class="fas fa-graduation-cap"></i></div>
                <div><span>EduTask</span><small>Manajemen Tugas</small></div>
            </div>
        </div>
        <nav class="sidebar-nav">
            <a href="dashboard.html" class="nav-link ${activePage === 'dashboard' ? 'active' : ''}">
                <i class="fas fa-home"></i><span>Dashboard</span>
            </a>
            <a href="tugas.html" class="nav-link ${activePage === 'tugas' ? 'active' : ''}">
                <i class="fas fa-list-check"></i><span>Daftar Tugas</span>
            </a>
            <a href="tambah.html" class="nav-link ${activePage === 'tambah' ? 'active' : ''}">
                <i class="fas fa-plus-circle"></i><span>Tambah Tugas</span>
            </a>
            <a href="statistik.html" class="nav-link ${activePage === 'statistik' ? 'active' : ''}">
                <i class="fas fa-chart-bar"></i><span>Statistik</span>
            </a>
            <a href="game.html" class="nav-link ${activePage === 'game' ? 'active' : ''} ${allDone ? 'game-unlocked' : ''}" id="navGame">
                <i class="fas fa-gamepad"></i><span>Game</span>
                ${allDone 
                    ? '<i class="fas fa-unlock unlock-icon" style="color:#22C55E; margin-left:auto;"></i>' 
                    : '<i class="fas fa-lock lock-icon"></i>'}
            </a>
            <a href="tentang.html" class="nav-link ${activePage === 'tentang' ? 'active' : ''}">
                <i class="fas fa-info-circle"></i><span>Tentang</span>
            </a>
            
            <!-- Tombol Dark Mode -->
            <div class="theme-toggle" onclick="toggleDarkMode()">
                <i class="fas fa-moon" id="themeIcon"></i>
                <span id="themeText">Mode Gelap</span>
                <div class="toggle-switch"></div>
            </div>
        </nav>
        <div class="sidebar-footer">
            <a href="#" class="nav-link" onclick="logout(); return false;">
                <i class="fas fa-sign-out-alt"></i><span>Keluar</span>
            </a>
        </div>
    `;
    
    // Pastikan ikon sesuai dengan tema saat ini setelah render ulang
    updateThemeIcon();
}