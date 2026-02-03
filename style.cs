:root {
    --primary-color: #ff4d6d; /* Vibrant like Hopscotch */
    --text-color: #2d3436;
    --bg-color: #f9f9f9;
    --white: #ffffff;
    --transition: all 0.3s ease;
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    background-color: var(--bg-color);
    color: var(--text-color);
    line-height: 1.6;
}

.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 20px;
}

/* Header */
.main-header {
    background: var(--white);
    padding: 15px 0;
    position: sticky;
    top: 0;
    z-index: 1000;
    box-shadow: 0 2px 10px rgba(0,0,0,0.05);
}

.navbar {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.logo {
    font-size: 24px;
    font-weight: 700;
    letter-spacing: -1px;
}

.logo span { color: var(--primary-color); }

.nav-links {
    display: flex;
    list-style: none;
}

.nav-links li a {
    text-decoration: none;
    color: var(--text-color);
    margin: 0 15px;
    font-weight: 500;
    transition: var(--transition);
}

.nav-links li a:hover { color: var(--primary-color); }

/* Hero Section */
.hero {
    height: 60vh;
    background: linear-gradient(rgba(0,0,0,0.3), rgba(0,0,0,0.3)), 
                url('https://images.unsplash.com/photo-1549465220-1a8b9238cd48?auto=format&fit=crop&w=1350&q=80');
    background-size: cover;
    background-position: center;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    color: var(--white);
    margin-bottom: 50px;
}

.hero h1 { font-size: 3rem; margin-bottom: 10px; }

.cta-button {
    display: inline-block;
    padding: 12px 30px;
    background: var(--primary-color);
    color: var(--white);
    text-decoration: none;
    border-radius: 50px;
    margin-top: 20px;
    transition: var(--transition);
}

.cta-button:hover { transform: scale(1.05); background: #ef233c; }

/* Product Grid */
.section-title { text-align: center; margin-bottom: 40px; font-size: 28px; }

.product-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 30px;
}

.product-card {
    background: var(--white);
    border-radius: 12px;
    overflow: hidden;
    transition: var(--transition);
}

.product-card:hover { transform: translateY(-10px); box-shadow: 0 15px 30px rgba(0,0,0,0.1); }

.product-image { position: relative; }
.product-image img { width: 100%; display: block; }

.badge {
    position: absolute;
    top: 10px;
    left: 10px;
    background: var(--primary-color);
    color: white;
    padding: 5px 12px;
    font-size: 12px;
    border-radius: 4px;
}

.product-info { padding: 20px; text-align: center; }
.price { font-weight: 600; color: var(--primary-color); margin: 10px 0; }

.add-to-cart {
    width: 100%;
    padding: 10px;
    border: 2px solid var(--primary-color);
    background: transparent;
    color: var(--primary-color);
    font-weight: 600;
    cursor: pointer;
    transition: var(--transition);
}

.add-to-cart:hover { background: var(--primary-color); color: white; }
